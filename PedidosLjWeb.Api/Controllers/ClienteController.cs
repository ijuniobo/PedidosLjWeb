using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PedidosLjWeb.Application.Dto;
using PedidosLjWeb.Application.Servicos;

namespace PedidosLjWeb.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private ClienteService _clienteService;

        public ClienteController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public IActionResult GetClientes()
        {
            var result = this._clienteService.ObterTodos();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetCliente(int id)
        {
            var result = this._clienteService.Obter(id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Criar([FromBody] ClienteDto dto)
        {
            if (ModelState is { IsValid: false })
                return BadRequest();

            var result = this._clienteService.Criar(dto);

            return Created($"/cliente/{result.Id}", result);
        }

        [HttpPost("Atualizar")]
        public IActionResult Atualizar([FromBody] ClienteDto dto)
        {
            if (ModelState is { IsValid: false })
                return BadRequest();

            var result = this._clienteService.Atualizar(dto);

            return Ok(result);
        }


        [HttpDelete]
        public IActionResult Deletar([FromBody] ClienteDto dto)
        {
            if (ModelState is { IsValid: false })
                return BadRequest();

            var result = this._clienteService.Deletar(dto);

            return Ok(result);
        }

        [HttpGet("pesquisa/{nome}")]
        public IActionResult PesquisaCliente(string nome)
        {
            var result = this._clienteService.Pesquisa(nome);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }


    }
}
