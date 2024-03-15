using PedidosLjWeb.Domain.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosLjWeb.Repository.Repository
{
    public class PedidoRepository : RepositoryBase<Pedido>
    {
        public PedidoRepository(PedidosLjWebContext context) : base(context)
        {
        }
    }
}
