using PedidosLjWeb.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PedidosLjWeb.Domain.Pedidos
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Endereco { get; set; }

        public string Cidade { get; set; }

        public string Bairro {get; set; }

        public string Estado { get; set; }

        public string Complemento { get; set; }

        public string Cep { get; set; }

        public string Cpf { get; set; }

        public string Cnpj { get; set; }

        public string TipoPessoa { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public List<Pedido> Pedidos { get; set; }

        public void CriarCliente(string nome, string endereco, string cidade, string bairro, string estado, string complemento, string cpf, string cnpj, string tipoPessoa, string login, string senha) 
        {
            this.Nome = nome;
            this.Endereco = endereco;
            this.Cidade = cidade;
            this.Bairro = bairro;
            this.Estado = estado;
            this.Complemento = complemento;
            this.Cpf = cpf;
            this.Cnpj = cnpj;
            this.TipoPessoa = tipoPessoa;
            this.Login = login;
            this.Senha = CriptografarSenha(senha);

        }


        private String CriptografarSenha(string senhaAberta)
        {
            SHA256 criptoProvider = SHA256.Create();

            byte[] btexto = Encoding.UTF8.GetBytes(senhaAberta);

            var criptoResult = criptoProvider.ComputeHash(btexto);

            return Convert.ToHexString(criptoResult);
        }

    }
}
