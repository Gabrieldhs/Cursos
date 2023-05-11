namespace ProEventos.Domain;

public class RedeSocial
{
    public long Id { get; set; }
    public string Nome { get; set; }
    public string URL { get; set; }
    public long? IdEvento { get; set; }
    public Evento Evento { get; set; }
    public long? IdPalestrante { get; set; }
    public Palestrante? Palestrante { get; set; }
}