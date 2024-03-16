using PedidosLjWeb.Application.Dto;
using PedidosLjWeb.Domain.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosLjWeb.Application.Profile
{
    public class PedidoProfile : AutoMapper.Profile
    {
       public PedidoProfile()
         {
            CreateMap<PedidoDto, Pedido>()
                    .ReverseMap();
         }

    }
}
