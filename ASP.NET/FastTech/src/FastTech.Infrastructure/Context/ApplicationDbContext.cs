using FastTech.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FastTech.Infrastructure.Context;

public class ApplicationDbContext : DbContext
{
    public DbSet<Produto> Produtos { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .LogTo(x => Console.WriteLine(x))
            .EnableSensitiveDataLogging();
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        base.OnModelCreating(modelBuilder); 
    }

    // Toda coluna tipo STRING seta como DEFAULT tamanho 500
    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder
            .Properties<string>()
            .AreUnicode()
            .HaveMaxLength(500);
            
        base.ConfigureConventions(configurationBuilder);
    }
}
