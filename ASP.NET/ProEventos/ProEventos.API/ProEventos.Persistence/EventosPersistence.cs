using Microsoft.EntityFrameworkCore;
using ProEventos.Domain;
using ProEventos.Persistence.Contratos;

namespace ProEventos.Persistence;

public class EventosPersistence : IEventoPersist
{
    private readonly DataContext _context;

    public EventosPersistence(DataContext context)
    {
        _context = context;
    }
    public async Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false)
    {
        IQueryable<Evento> query = _context.Eventos
            .Include(e => e.Lotes)
            .Include(e => e.RedesSocials);

     if (includePalestrantes)
        {
            query = query
                .Include(e => e.PalestrantesEventos)
                .ThenInclude(pe => pe.Palestrante);
                   
        }
         
        query = query.OrderBy(e => e.Id);
        return await query.ToArrayAsync();
    }

    public async Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false)
    {
        IQueryable<Evento> query = _context.Eventos
            .Include(e => e.Lotes)
            .Include(e => e.RedesSocials);

        if (includePalestrantes)
        {
            query = query
                .Include(e => e.PalestrantesEventos)
                .ThenInclude(pe => pe.Palestrante);

        }

        query = query.OrderBy(e => e.Id)
            .Where(e => e.Tema.ToLower().Contains(tema.ToLower()));
        return await query.ToArrayAsync();
    }
        
    public async Task<Evento> GetEventosByIdAsync(long idEvento, bool includePalestrantes = false)
    {
        IQueryable<Evento> query = _context.Eventos
            .Include(e => e.Lotes)
            .Include(e => e.RedesSocials);

        if (includePalestrantes)
        {
            query = query
                .Include(e => e.PalestrantesEventos)
                .ThenInclude(pe => pe.Palestrante);

        }

        query = query.OrderBy(e => e.Id)
            .Where(e => e.Id == idEvento);
        return await query.FirstOrDefaultAsync();
    }



}
