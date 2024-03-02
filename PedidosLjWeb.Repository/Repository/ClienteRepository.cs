using PedidosLjWeb.Domain.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosLjWeb.Repository.Repository
{
    public class ClienteRepository : RepositoryBase<Cliente>
    {
        public ClienteRepository(PedidosLjWebContext context) : base(context)
        {
        }
    }
}
