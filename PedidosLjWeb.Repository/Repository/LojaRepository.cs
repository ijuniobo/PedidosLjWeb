using PedidosLjWeb.Domain.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosLjWeb.Repository.Repository
{
    public class LojaRepository : RepositoryBase<Loja>
    {
        public LojaRepository(PedidosLjWebContext context) : base(context)
        {
        }
    }
}
