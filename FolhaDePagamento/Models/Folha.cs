namespace FolhaDePagamento.Models;
// Models/FolhaDePagamento.cs
public class Folha 
{
    public int FuncionarioId { get; set; }

    public Object? Nome {get; set;}
    public string? CPF { get; set; }
    public int Mes { get; set; }
    public int Ano { get; set; }
    public double Salario { get; set; }
    public double ValorHora { get; set; }
    public double QuantidadeDeHoras { get; set; }
    public double ImpostoRenda { get; set; }
    public double Inss { get; set; }
    public double SalarioLiquido { get; set; }
    public double Fgts { get; set; }





}
