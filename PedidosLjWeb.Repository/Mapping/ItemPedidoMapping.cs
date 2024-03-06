using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PedidosLjWeb.Domain.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PedidosLjWeb.Domain.ValueObject;

namespace PedidosLjWeb.Repository.Mapping
{

    public class ItemPedidoMapping : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.ToTable(nameof(ItemPedido));


            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Quantidade).IsRequired();

            builder.OwnsOne<Monetario>(d => d.PrecoUnitario, c =>
            {
                c.Property(x => x.Valor).IsRequired();
            });

            builder.OwnsOne<Monetario>(d => d.PrecoTotal, c =>
            {
                c.Property(x => x.Valor).IsRequired();
            });

            builder.OwnsOne<Monetario>(d => d.Desconto, c =>
            {
                c.Property(x => x.Valor);
            });

            builder.Property(x => x.IdProduto).IsRequired();
            builder.Property(x => x.IdPedido).IsRequired();

        }
    }
}
