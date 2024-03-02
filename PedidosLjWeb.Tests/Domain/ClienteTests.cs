using PedidosLjWeb.Domain.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PedidosLjWeb.Tests.Domain
{
    public class ClienteTests
    {
        [Fact]
        public void DeveCriarClienteComSucesso() 
        {
            Cliente cliente = new Cliente()
            {
                Id = 1,
                Nome = "Isaias Barcelos",
                Endereco = "Alameda são boaventura",
                Cidade = "Niteroi",
                Bairro = "Fonseca",
                Estado = "RJ",
                Complemento = "931 c34",
                Cep = "24130-001",
                Cpf = "00667719784",
                TipoPessoa = "Fisica",
                Login = "Ijuniorbo",
                Senha = "123456"
            };

            cliente.CriarCliente(cliente.Nome, cliente.Endereco, cliente.Bairro, cliente.Cidade, cliente.Estado, cliente.Complemento, cliente.Cpf, "", cliente.TipoPessoa, cliente.Login, cliente.Senha);

            Assert.True(cliente.Nome == "Isaias Barcelos");

        }

        [Fact]
        public void DeveCriarClienteSemSucesso()
        {
            Cliente cliente = new Cliente()
            {
                Id = 1,
                Nome = "Isaias Barcelos",
                Endereco = "Alameda são boaventura",
                Cidade = "Niteroi",
                Bairro = "Fonseca",
                Estado = "RJ",
                Complemento = "931 c34",
                Cep = "24130-001",
                Cpf = "00667719784",
                TipoPessoa = "Fisica",
                Login = "Ijuniorbo",
                Senha = "123456"
            };

            cliente.CriarCliente(cliente.Nome, cliente.Endereco, cliente.Bairro, cliente.Cidade, cliente.Estado, cliente.Complemento, cliente.Cpf, "", cliente.TipoPessoa, cliente.Login, cliente.Senha);

            Assert.False(cliente.Nome == "Isaias Barcelosss");

        }

    }
}
