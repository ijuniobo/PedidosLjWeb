using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PedidosLjWeb.Application.Dto;
using PedidosLjWeb.Application.Servicos;

namespace PedidosLjWeb.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private ProdutoService _produtoService;

        public ProdutoController(ProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        public IActionResult GetProdutos()
        {
            var result = this._produtoService.ObterTodos();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetProduto(int id)
        {
            var result = this._produtoService.Obter(id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Criar([FromBody] ProdutoDto dto)
        {
            if (ModelState is { IsValid: false })
                return BadRequest();

            var result = this._produtoService.Criar(dto);

            return Created($"/produto/{result.Id}", result);
        }

        [HttpDelete]
        public IActionResult Deletar([FromBody] ProdutoDto dto)
        {
            if (ModelState is { IsValid: false })
                return BadRequest();

            var result = this._produtoService.Deletar(dto);

            return Created($"/produto/{result.Id}", result);
        }

    }
}
