using PedidosLjWeb.Domain.Pedidos;
using PedidosLjWeb.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosLjWeb.Application.Dto
{
    public class PedidoDto
    {
        public int Id { get; set; }

        public DateTime DataPedido { get; set; }

        public DateTime DataEnvio { get; set; }

        public int QuantidadeTotal { get; set; }

        public decimal ValorTotal { get; set; }

        public decimal Desconto { get; set; }

        public decimal ValorLiquido { get; set; }

        public int IdCliente { get; set; }

        public int IdLoja { get; set; }

        public List<ItemPedidoDto> Itens { get; set; } = new List<ItemPedidoDto>();

    }
}
