using FastTech.Domain.Entities;
using FastTech.Domain.Interfaces;
using MediatR;

namespace FastTech.Application.Services.ProdutoHandler
{
    public class ProdutoCommandHandler : IRequestHandler<CadastrarProdutoCommand, bool>
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoCommandHandler(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<bool> Handle(CadastrarProdutoCommand request, CancellationToken cancellationToken)
        {
            var produto = new Produto(request.Nome, request.Descricao, request.Valor, request.Tipo, request.QuantidadeEstoque);

            await _produtoRepository.Adicionar(produto);
            return true;

        }
    }
}