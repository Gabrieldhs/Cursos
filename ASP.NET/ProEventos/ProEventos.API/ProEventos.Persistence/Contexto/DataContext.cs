using Microsoft.EntityFrameworkCore;
using ProEventos.Domain;

namespace ProEventos.Persistence;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    public DbSet<Evento> Eventos { get; set; }
    public DbSet<Lote> Lotes { get; set; }
    public DbSet<Palestrante> Palestrantes { get; set; }
    public DbSet<PalestranteEvento> PalestrantesEventos { get; set; }
    public DbSet<RedeSocial> RedeSocials { get; set; }


    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.Entity<PalestranteEvento>()
            .HasKey(PE => new { PE.IdEvento, PE.IdPalestrante });
    }
}
