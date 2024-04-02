using PedidosLjWeb.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PedidosLjWeb.Domain.Pedidos
{
    public class Pedido
    {
        public int Id { get; set; }

        public DateTime DataPedido { get; set; }

        public DateTime DataEnvio { get; set; }

        public  int QuantidadeTotal { get; set; }

        public Monetario ValorTotal { get; set; }

        public Monetario Desconto { get; set; }

        public Monetario ValorLiquido { get; set; }

        public int IdCliente { get; set; }

        public int IdLoja { get; set; }

        public int ClienteId { get; set; }

        public int LojaId { get; set; }


        public Cliente Cliente { get; set; }

        public Loja Loja { get; set; }

        public List<ItemPedido> Itens { get; set; } = new List<ItemPedido>();


        public void CriarPedido(DateTime dataPedido, Cliente cliente, int idLoja, List<ItemPedido> itensPedido)
        {
            if (cliente == null)
               throw new Exception("Pedido deve conter um cliente!!");

            if (idLoja == 0)
                throw new Exception("Pedido deve conter uma loja!!");

            if (itensPedido.Count() == 0)
                throw new Exception("Pedido deve conter um item!!");

            int qtdTotal = 0;
            decimal vlTotal = 0;
            foreach (var item in itensPedido)
            {
                qtdTotal = item.Quantidade;
                item.PrecoTotal = item.Quantidade * item.PrecoUnitario;
                qtdTotal += item.Quantidade;
                vlTotal += item.PrecoTotal;
            }

            this.IdLoja = idLoja;
            this.IdCliente = cliente.Id;
            this.DataPedido = dataPedido;

            this.ValorLiquido = vlTotal;
            this.ValorTotal = vlTotal;
            this.QuantidadeTotal = qtdTotal;

        }


        public void AdicionarItem(ItemPedido itemPedido) =>
        this.Itens.Add(itemPedido);
    }


}
