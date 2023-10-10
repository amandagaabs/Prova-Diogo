using Microsoft.EntityFrameworkCore;

namespace FolhaDePagamento.Models
{
public class AppDataContext : DbContext
{
    public DbSet<Funcionario> Funcionarios { get; set; }
    public DbSet<Folha> Folhas { get; set; }

    public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
    {
                    Funcionarios = Set<Funcionario>();
                    Folhas = Set<Folha>();


    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Defina configurações adicionais para suas entidades aqui, se necessário
        base.OnModelCreating(modelBuilder);
    }
}
}