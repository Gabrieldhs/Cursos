using FastTech.Core.Common;
using FastTech.Domain.Enum;

namespace FastTech.Domain.Entities;
public class Produto : Entity
{
    public Produto(string nome, string descricao, decimal valor,
                    TipoProduto tipo, int quantidadeEstoque)
    {
        Nome = nome;
        Descricao = descricao;
        Ativo = true;
        Valor = valor;
        Cadastro = DateTime.UtcNow;
        Tipo = tipo;
        QuantidadeEstoque = quantidadeEstoque;

        Validar();
    }

    public string Nome { get; private set; }
    public string Descricao { get; private set; }
    public bool Ativo { get; private set; }
    public decimal Valor { get; private set; }
    public DateTime Cadastro { get; private set; }
    public TipoProduto Tipo { get; private set; }
    public int QuantidadeEstoque { get; private set; }
    public void Ativar() => Ativo = true;
    public void Desativar() => Ativo = false;
    public void AlterarTipo(TipoProduto novoTipo) => Tipo = novoTipo;

    public void AlterarNome(string novoNome)
    {
        if (string.IsNullOrWhiteSpace(novoNome))
            throw new DomainException("Nome Inválido");
        Nome = novoNome;
    }
    public void AlterarDescricao(string novaDescricao)
    {
        if (string.IsNullOrWhiteSpace(novaDescricao))
            throw new DomainException("Descrição Inválida");
        Descricao = novaDescricao;
    }
    public void DebitarEstoque(int quantidade)
    {
        if (quantidade < 0)
            throw new DomainException("Quantidade Inválida");

        if (!PossuiEstoque(quantidade))
        {
            throw new DomainException("Quantidade em estoque insuficiente");
        }
        QuantidadeEstoque -= quantidade;
    }
    public bool PossuiEstoque(int quantidade) => QuantidadeEstoque >= quantidade;
    public void AdicionarEstoque(int quantidade)
    {
        QuantidadeEstoque += quantidade;
    }

    protected override void Validar()
    {
        if (string.IsNullOrWhiteSpace(Nome))
            throw new DomainException("O nome não pode ser vázio");

        if (string.IsNullOrWhiteSpace(Descricao))
            throw new DomainException("A descrição não pode ser vázio");

        if (Valor <= 0)
            throw new DomainException("O valor não pode ser menor ou igual a 0");

        if (Cadastro.Date < DateTime.UtcNow.Date)
            throw new DomainException("O produto não pode ser cadastrado em uma data retroaiva");

        if (QuantidadeEstoque < 0)
            throw new DomainException("Quantidade inválida");
    }
}
