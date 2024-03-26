using PedidosLjWeb.Application.Dto;
using PedidosLjWeb.Domain.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosLjWeb.Application.Servicos
{
    public interface IPedidoService
    {
        PedidoDto Criar(PedidoDto dto);

        PedidoDto Atualizar(PedidoDto dto);

        PedidoDto Obter(int id);

        IEnumerable<PedidoDto> ObterTodos();

        PedidoDto Deletar(PedidoDto dto);

    }
}
