using FastTech.Application.Services.ProdutoHandler;
using FastTech.Core.Common.Mediatr;
using FastTech.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FastTech.Web.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProdutosController : MainController
{
    private readonly IMediatrHandler _handler;

    public ProdutosController(IMediatrHandler handler)
    {
        _handler = handler;
    }

    [HttpPost]
    public async Task<IActionResult> CadastrarProduto([FromBody] CadastrarProdutoCommand command)
    {
        return Ok(await _handler.EnviarComando(command));
    }
}
