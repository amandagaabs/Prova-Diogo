using Microsoft.AspNetCore.Mvc;
using FolhaDePagamento.Models;
using System;
using FolhaDePagamento.Data;

namespace FolhaDePagamento.Controller;

// Controllers/FolhaController.cs
[Route("api/folha")]
[ApiController]
public class FolhaController : ControllerBase
{
    private readonly DataContext _context;

    public FolhaController(DataContext context)
    {
        _context = context;
    }

    // POST api/folha/cadastrar
    [HttpPost("cadastrar")]
    public IActionResult Cadastrar([FromBody] Folha folha)
        {
            folha.Nome = _context.Funcionarios.Find(folha.FuncionarioId);
            folha.Salario = folha.ValorHora * folha.QuantidadeDeHoras;

            if (folha.Nome != null)
            {
                //Imposto de renda

                switch (folha.Salario)
                {
                    case < 1903.99:
                        folha.ImpostoRenda = 0;
                        break;

                    case < 2826.66:
                        folha.ImpostoRenda = folha.Salario * 0.075 - 142.8;
                        break;

                    case < 3751.06:
                        folha.ImpostoRenda = folha.Salario * 0.015 - 354.80;
                        break;

                    case < 4664.69:
                        folha.ImpostoRenda = folha.Salario * 0.0225 - 636.13;
                        break;

                    default:
                        folha.ImpostoRenda = folha.Salario * 0.0275 - 869.36;
                        break;

                }



                switch (folha.Salario)
                {
                    case < 1693.73:
                        folha.Salario = folha.Salario * 0.08;
                        break;

                    case < 2822.91:
                        folha.Salario = folha.Salario * 0.09;
                        break;

                    case < 5645.81:
                        folha.Salario = folha.Salario * 0.011;
                        break;

                    default:
                        folha.Salario = folha.Salario - 621.03;
                        break;

                }



                folha.SalarioLiquido = folha.Salario - folha.ImpostoRenda - folha.Inss;
                folha.Fgts = folha.Salario * 0.08;

                _context.Folhas.Add(folha);
                _context.SaveChanges();
                return Created("", folha);
            }
            return NotFound();
}

    // GET api/folha/listar
    [HttpGet("listar")]
    public IActionResult ListarFolhasDePagamento()
    {
   
        return Ok();
    }

    // GET api/folha/buscar/{cpf}/{mes}/{ano}
    [HttpGet("buscar/{cpf}/{mes}/{ano}")]
    public IActionResult BuscarFolhaDePagamento(string cpf, int mes, int ano)
    {
   
        return NotFound();
    }
    
}
