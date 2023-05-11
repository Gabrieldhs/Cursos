using FastTech.Core.Common;

namespace FastTech.Domain.Entities;

public class PedidoItem : Entity
{
    public Guid IdPedido { get; private set; }
    public Guid IdProduto { get; private set; }
    public int Quantidade { get; private set; }
    public decimal ValorUnitario { get; private set; }
    public string? NomeProduto { get; private set; }
    public Pedido? Pedido { get; set; }

    public PedidoItem(Guid idProduto, int quantidade, decimal valorUnitario, string nomeProduto)
    {
        IdProduto = idProduto;
        Quantidade = quantidade;
        ValorUnitario = valorUnitario;
        NomeProduto = nomeProduto;

        Validar();
    }

    public void VincularPeido(Guid idPedido)
    {
        IdPedido = idPedido;
    }

    public decimal CalcularValor()
    {
       return  ValorUnitario * Quantidade;
    }

    public void AdicionarQuantidade(int quantidade)
    {
        Quantidade += quantidade;
    }

    public void AtualizarQuantidade(int quantidade)
    {
        Quantidade = quantidade;
    }

    protected override void Validar()
    {
        if (IdProduto == Guid.Empty)
            throw new DomainException("Id do produto incorreto!");
        
        if(Quantidade <= 0)
            throw new DomainException("Quantidade deve ser maior que 0");
        
        if (ValorUnitario <= 0)
            throw new DomainException("Valor deve ser maior que 0");

        if (string.IsNullOrWhiteSpace(NomeProduto))
            throw new DomainException("Nome do produto inválido");

    }
}