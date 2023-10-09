using Microsoft.AspNetCore.Mvc;
using FolhaDePagamento.Models;
using System;

namespace FolhaDePagamento.Controller;

// Controllers/FuncionarioController.cs
[Route("api/[controller]")]
[ApiController]
public class FuncionarioController : ControllerBase
{
    // POST api/funcionario/cadastrar
    [HttpPost("cadastrar")]
    public IActionResult CadastrarFuncionario([FromBody] Funcionario funcionario)
    {
        // Lógica para cadastrar o funcionário
        // Retorna CreatedAtAction com o novo funcionário
        return CreatedAtAction(nameof(CadastrarFuncionario), new { id = funcionario.FuncionarioId }, funcionario);
    }

    // GET api/funcionario/listar
    [HttpGet("listar")]
    public IActionResult ListarFuncionarios()
    {
        // Lógica para listar os funcionários
        // Retorna uma lista de funcionários
        return Ok(/* lista de funcionários */);
    }
}
