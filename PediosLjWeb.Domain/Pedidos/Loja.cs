using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosLjWeb.Domain.Pedidos
{
    public class Loja
    {
        public int Id { get; set; }

        public string  Descricao { get; set; }

        public string Fantasia { get; set; }

        public string Endereco { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string Cnpj { get; set; }

        public List<Pedido> Pedidos { get; set; }   

    }
}
