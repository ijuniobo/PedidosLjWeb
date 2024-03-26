using PedidosLjWeb.Application.Dto;
using PedidosLjWeb.Domain.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosLjWeb.Application.Servicos
{
    public interface IProdutoService
    {
        ProdutoDto Criar(ProdutoDto dto);

        ProdutoDto Atualizar(ProdutoDto dto);

        ProdutoDto Obter(int id);

        IEnumerable<ProdutoDto> ObterTodos();

        ProdutoDto Deletar(ProdutoDto dto);

    }
}
