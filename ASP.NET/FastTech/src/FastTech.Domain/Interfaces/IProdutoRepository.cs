using FastTech.Domain.Entities;

namespace FastTech.Domain.Interfaces;

public interface IProdutoRepository
{
    Task<IEnumerable<Produto>> BuscarTodosAsync();
    Task Adicionar(Produto produto);
}
