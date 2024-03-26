using PedidosLjWeb.Application.Dto;
using PedidosLjWeb.Domain.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosLjWeb.Application.Servicos
{
    public interface ILojaService
    {
        LojaDto Criar(LojaDto dto);

        LojaDto Atualizar(LojaDto dto);

        LojaDto Obter(int id);

        IEnumerable<LojaDto> ObterTodos();

        LojaDto Deletar(LojaDto dto);

    }
}
