using dotnet_fluxo_de_caixa.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_fluxo_de_caixa.db;

public class MeuDbContext : DbContext
{

    public MeuDbContext(DbContextOptions<MeuDbContext> options) : base(options) {}
    
    public DbSet<Caixa> Caixas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Caixa>(entity => 
            {
                entity.Property(e => e.Tipo).HasColumnType("VARCHAR(255)");

                entity.HasKey(e => e.Id);
            });
        }
}
