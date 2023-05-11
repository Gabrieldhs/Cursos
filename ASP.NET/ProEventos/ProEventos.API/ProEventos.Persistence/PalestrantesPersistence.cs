using Microsoft.EntityFrameworkCore;
using ProEventos.Domain;
using ProEventos.Persistence.Contratos;

namespace ProEventos.Persistence;

public class PalestrantesPersistence : IPalestrantePersist
{
    private readonly DataContext _context;

    public PalestrantesPersistence(DataContext context)
    {
        _context = context;
    }
    public async Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includeEventos)
    {
        IQueryable<Palestrante> query = _context.Palestrantes
            .Include(pe => pe.RedesSocials);

        if (includeEventos)
        {
            query = query
                .Include(pe => pe.PalestrantesEventos)
                .ThenInclude(pe => pe.Evento);

        }

        query = query.OrderBy(pe => pe.Id)
            .Where(e => e.Nome.ToLower().Contains(nome.ToLower()));
        return await query.ToArrayAsync();
    }

    public async Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos = false)
    {
        IQueryable<Palestrante> query = _context.Palestrantes
            .Include(pe => pe.RedesSocials);

        if (includeEventos)
        {
            query = query
                .Include(pe => pe.PalestrantesEventos)
                .ThenInclude(pe => pe.Evento);

        }

        query = query.OrderBy(e => e.Id);
        return await query.ToArrayAsync();
    }

    public async Task<Palestrante> GetAllPalestrantesByIdAsync(long idPalestrante, bool includeEventos)
    {
        IQueryable<Palestrante> query = _context.Palestrantes
           .Include(pe => pe.RedesSocials);

        if (includeEventos)
        {
            query = query
                .Include(pe => pe.PalestrantesEventos)
                .ThenInclude(pe => pe.Evento);

        }

        query = query.OrderBy(pe => pe.Id)
            .Where(pe => pe.Id == idPalestrante);
        return await query.FirstOrDefaultAsync();
    }

   

}
