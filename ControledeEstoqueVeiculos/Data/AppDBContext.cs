using ControledeEstoqueVeiculos.Models;
using Microsoft.EntityFrameworkCore;

namespace ControledeEstoqueVeiculos.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Veiculo> Veiculos { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Veiculo>(entity =>
        {
            entity.ToTable("VEICULOS");
            entity.HasKey(v => v.Id);

            entity.HasQueryFilter(v => v.IsAtivo);
        });
    }
}