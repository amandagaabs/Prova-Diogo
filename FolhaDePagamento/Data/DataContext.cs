using FolhaDePagamento.Models;
using Microsoft.EntityFrameworkCore;
using FolhaDePagamento.Controller;

namespace FolhaDePagamento.Data
{
public class DataContext : DbContext
{
    public DbSet<Funcionario> Funcionarios { get; set; }
    public DbSet<Folha> Folhas { get; set; }

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Defina configurações adicionais para suas entidades aqui, se necessário
        base.OnModelCreating(modelBuilder);
    }
}
}