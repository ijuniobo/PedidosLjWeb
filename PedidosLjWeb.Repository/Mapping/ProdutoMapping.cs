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
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable(nameof(Produto));


            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(2000);
            builder.Property(x => x.CodBarras).IsRequired().HasMaxLength(13);
            builder.Property(x => x.TipoProduto).HasMaxLength(200);

            builder.OwnsOne<Monetario>(d => d.PrecoCusto, c =>
            {
                c.Property(x => x.Valor).IsRequired();
            });
            builder.OwnsOne<Monetario>(d => d.PrecoVenda, c =>
            {
                c.Property(x => x.Valor).IsRequired();
            });

            builder.Property(x => x.Estoque).IsRequired();

            builder.HasMany(x => x.Itens).WithOne();

        }
    }
}
