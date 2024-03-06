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
    public class PedidoMapping : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable(nameof(Pedido));

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.DataPedido).IsRequired();
            builder.Property(x => x.DataEnvio);
            builder.Property(x => x.QuantidadeTotal).IsRequired();
            builder.OwnsOne<Monetario>(d => d.ValorTotal, c =>
            {
                c.Property(x => x.Valor).IsRequired();
            });

            builder.OwnsOne<Monetario>(d => d.ValorLiquido, c =>
            {
                c.Property(x => x.Valor).IsRequired();
            });

            builder.OwnsOne<Monetario>(d => d.Desconto, c =>
            {
                c.Property(x => x.Valor);
            });

            builder.Property(x => x.IdCliente).IsRequired();
            builder.Property(x => x.IdLoja).IsRequired();

            builder.HasMany(x => x.Itens).WithOne();

        }
    }
}
