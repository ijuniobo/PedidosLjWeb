using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosLjWeb.Domain.ValueObject
{
    public record CpfVObject
    {
        public string Cpf { get; set; }


        public string Formatado()
        {
            return Cpf.Substring(0,3) + "."  + Cpf.Substring(0, 3) + "." + Cpf.Substring(0, 3) + "-" + Cpf.Substring(0, 2);
        }


    }
}
