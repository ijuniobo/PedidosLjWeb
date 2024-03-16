using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosLjWeb.Application.Dto
{
    public class ClienteDto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Endereco { get; set; }

        public string Cidade { get; set; }

        public string Bairro { get; set; }

        public string Estado { get; set; }

        public string Complemento { get; set; }

        public string Cep { get; set; }

        public string Cpf { get; set; }

        public string Cnpj { get; set; }

        public string TipoPessoa { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

    }
}
