using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PedidosLjWeb.Application.Dto;
using PedidosLjWeb.Application.Servicos;

namespace PedidosLjWeb.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private PedidoService _pedidoService;

        public PedidoController(PedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpGet]
        public IActionResult GetPedidos()
        {
            var result = this._pedidoService.ObterTodos();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetPedido(int id)
        {
            var result = this._pedidoService.Obter(id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Criar([FromBody] PedidoDto dto)
        {
            if (ModelState is { IsValid: false })
                return BadRequest();

            var result = this._pedidoService.Criar(dto);

            return Created($"/pedido/{result.Id}", result);
        }

        [HttpPost("Atualizar")]
        public IActionResult Atualizar([FromBody] PedidoDto dto)
        {
            if (ModelState is { IsValid: false })
                return BadRequest();

            var result = this._pedidoService.Atualizar(dto);

            return Ok(result);
        }


        [HttpDelete]
        public IActionResult Deletar([FromBody] PedidoDto dto)
        {
            if (ModelState is { IsValid: false })
                return BadRequest();

            var result = this._pedidoService.Deletar(dto);

            return Ok(result);
        }

    }
}
