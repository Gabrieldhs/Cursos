using FastTech.Core.Common;
using FastTech.Domain.Enum;

namespace FastTech.Domain.Entities;
public class Pedido : Entity
{
    public DateTime Cadastro { get; set; }
    public decimal ValorTotal { get; set; }
    public StatusPedido Status { get; set; }
    
    private List<PedidoItem> _pedidoItens;
    public IReadOnlyCollection<PedidoItem> PedidoItens => _pedidoItens;

    public Pedido()
    {
        _pedidoItens = new List<PedidoItem>();
        Cadastro = DateTime.UtcNow;
        Status = StatusPedido.Novo;
    }

    public void CalcularValorTotal() =>
        ValorTotal = _pedidoItens.Sum(pi => pi.CalcularValor());


    public void AdicionarItemNoPedido(PedidoItem pedidoItem)
    {
        pedidoItem.VincularPeido(Id);

        //  verificar se o item já existe no seu pedido
        if (ExistePedidoItem(pedidoItem)
                is var itemEncontrado && itemEncontrado != null)
        {
            // incrementar a quantidade desse item 
            itemEncontrado.AdicionarQuantidade(pedidoItem.Quantidade);
            pedidoItem = itemEncontrado;
        }
        else
        {  
            _pedidoItens.Add(pedidoItem);
        }
        // calcular o valor do item
        pedidoItem.CalcularValor();

        // atualizar valor do pedido
        CalcularValorTotal();
    }
    public void RemoverItem(PedidoItem pedidoItem)
    {
        if (ExistePedidoItem(pedidoItem)
                  is var itemEncontrado && itemEncontrado == null)
        {
            throw new DomainException("O item não foi encontrado no pedido. Item Inválido!");
        }
        _pedidoItens.Remove(itemEncontrado);
        CalcularValorTotal();
    }

    public void AtualizarQuantidadeItem(PedidoItem item, int novaQuantidade)
    {
        if (ExistePedidoItem(item)
            is var itemEncontrado && itemEncontrado  == null)

        {
            throw new DomainException("O Item não encontrado");
        }

        itemEncontrado.AtualizarQuantidade(novaQuantidade);
        CalcularValorTotal();
    }

    public void AguardarPagamento()
    {
        Status = StatusPedido.EmAndamento;
    }

    public void ConcluirPedido()
    {
        Status = StatusPedido.Concluido;
    }
    public PedidoItem ExistePedidoItem(PedidoItem item)
    {
        return _pedidoItens.FirstOrDefault(pi => pi.IdProduto == item.IdPedido);
    }

    protected override void Validar()
    {
        if (Cadastro.Date <= DateTime.MinValue.Date)
            throw new DomainException("Data de Cadastro inválida");
    }
}
