using PedidosLjWeb.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosLjWeb.Domain.Pedidos
{
    public class Produto
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public string CodBarras { get; set; }

        public string TipoProduto { get; set; }

        public Monetario PrecoCusto { get; set; }

        public Monetario PrecoVenda { get; set; }

        public int Estoque { get; set; }


        public List<ItemPedido> Itens { get; set; }
    }
}
