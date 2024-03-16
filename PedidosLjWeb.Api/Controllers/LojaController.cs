using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PedidosLjWeb.Application.Dto;
using PedidosLjWeb.Application.Servicos;

namespace PedidosLjWeb.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LojaController : ControllerBase
    {
        private LojaService _lojaService;

        public LojaController(LojaService lojaService)
        {
            _lojaService = lojaService;
        }

        [HttpGet]
        public IActionResult GetLojas()
        {
            var result = this._lojaService.ObterTodos();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetLoja(int id)
        {
            var result = this._lojaService.Obter(id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost("Atualizar")]
        public IActionResult Criar([FromBody] LojaDto dto)
        {
            if (ModelState is { IsValid: false })
                return BadRequest();

            var result = this._lojaService.Criar(dto);

            return Created($"/loja/{result.Id}", result);
        }

        [HttpPost]
        public IActionResult Atualizar([FromBody] LojaDto dto)
        {
            if (ModelState is { IsValid: false })
                return BadRequest();

            var result = this._lojaService.Atualizar(dto);

            return Created($"/loja/{result.Id}", result);
        }


        [HttpDelete]
        public IActionResult Deletar([FromBody] LojaDto dto)
        {
            if (ModelState is { IsValid: false })
                return BadRequest();

            var result = this._lojaService.Deletar(dto);

            return Created($"/loja/{result.Id}", result);
        }

    }
}
