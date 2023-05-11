namespace ProEventos.Domain;

public class PalestranteEvento
{
    public long IdPalestrante { get; set; }
    public Palestrante Palestrante { get; set; }
    public long IdEvento { get; set; }
    public Evento Evento { get; set; }

}
