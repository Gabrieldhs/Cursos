using FastTech.Domain.Core.Messages;
using FastTech.Domain.Enum;

namespace FastTech.Application.Services.ProdutoHandler;

public class CadastrarProdutoCommand : Command
{
    public CadastrarProdutoCommand(string nome, string descricao, decimal valor, TipoProduto tipo, int quantidadeEstoque)
    {
        Nome = nome;
        Descricao = descricao;
        Valor = valor;
        Tipo = tipo;
        QuantidadeEstoque = quantidadeEstoque;
    }

    public string Nome { get; set; }
    public string Descricao { get; set; }
    public decimal Valor { get; set; }
    public TipoProduto Tipo { get; set; }
    public int QuantidadeEstoque { get; set; }
}
