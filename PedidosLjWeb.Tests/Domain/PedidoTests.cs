using PedidosLjWeb.Domain.Pedidos;
using PedidosLjWeb.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PedidosLjWeb.Tests.Domain
{
    public class PedidoTests
    {
        [Fact]
        public void DeveCriarPedidoComSucesso()
        {
            Pedido pedido = new Pedido();
            Cliente cliente = new Cliente() 
            { 
                Id = 1,
                Nome = "Isaias Barcelos",
                Endereco = "Alameda são boaventura",
                Cidade = "Niteroi",
                Bairro = "Fonseca",
                Estado = "RJ",
                Complemento= "931 c34",
                Cep = "24130-001",
                Cpf = "00667719784",
                TipoPessoa="Fisica",
                Login = "Ijuniorbo",
                Senha = "123456"
            };
            var dataPedido = DateTime.Now;
            var idLoja = 1;
            List<ItemPedido> itens = new List<ItemPedido>();
            Monetario prctotal = new Monetario() 
            { 
                Valor= 19.99M
            };
            ItemPedido item = new ItemPedido() 
            { 
                Id = 1,
                IdPedido = 1,
                IdProduto = 1,
                Quantidade = 1,
                PrecoTotal = prctotal,
                PrecoUnitario = prctotal
            };

            itens.Add(item);

            ItemPedido item2 = new ItemPedido()
            {
                Id = 1,
                IdPedido = 1,
                IdProduto = 1,
                Quantidade = 1,
                PrecoTotal = prctotal,
                PrecoUnitario = prctotal
            };

            itens.Add(item2);

            pedido.CriarPedido(dataPedido, cliente, idLoja, itens);
            Assert.True(pedido.Itens.Count > 0);

        }

        [Fact]
        public void DeveCriarPedidoSemSucesso()
        {
            Pedido pedido = new Pedido();
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
            var dataPedido = DateTime.Now;
            var idLoja = 0;
            List<ItemPedido> itens = new List<ItemPedido>();
            Monetario prctotal = new Monetario()
            {
                Valor = 19.99M
            };
            ItemPedido item = new ItemPedido()
            {
                Id = 1,
                IdPedido = 1,
                IdProduto = 1,
                Quantidade = 1,
                PrecoTotal = prctotal,
                PrecoUnitario = prctotal
            };

            itens.Add(item);

            ItemPedido item2 = new ItemPedido()
            {
                Id = 1,
                IdPedido = 1,
                IdProduto = 1,
                Quantidade = 1,
                PrecoTotal = prctotal,
                PrecoUnitario = prctotal
            };

            itens.Add(item2);

            Assert.Throws<System.Exception>(
               () => pedido.CriarPedido(dataPedido, cliente, idLoja, itens));

        }
    }
}
