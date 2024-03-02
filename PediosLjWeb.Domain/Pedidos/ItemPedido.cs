using PedidosLjWeb.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosLjWeb.Domain.Pedidos
{
    public class ItemPedido
    {
        public int Id { get; set; }

        public int Quantidade { get; set; }

        public Monetario PrecoUnitario { get; set; }

        public Monetario PrecoTotal { get; set; }

        public Monetario Desconto { get; set; }

        public int IdProduto { get; set; }

        public int IdPedido { get; set; }

        public  Produto Produto { get; set; }

        public Pedido Pedido { get; set; }

    }
}
