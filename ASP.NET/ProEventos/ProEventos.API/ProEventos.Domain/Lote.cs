namespace ProEventos.Domain;

public class Lote
{
    public long Id { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public int Quantidade { get; set; }
    public long IdEvento { get; set; }
    public Evento Evento { get; set; }
}
