using PedidosLjWeb.Application.Dto;
using PedidosLjWeb.Domain.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosLjWeb.Application.Servicos
{
    public interface IClienteService
    {
        ClienteDto Criar(ClienteDto dto);

        ClienteDto Atualizar(ClienteDto dto);

        ClienteDto Obter(int id);

        IEnumerable<ClienteDto> ObterTodos();

        ClienteDto Deletar(ClienteDto dto);

        List<ClienteDto> Pesquisa(string nome);

    }
}
