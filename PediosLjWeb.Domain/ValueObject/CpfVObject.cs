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

        public static implicit operator string(CpfVObject d) => d.Cpf;
        public static implicit operator CpfVObject(string Cpf) => new CpfVObject(Cpf);

    }
}
