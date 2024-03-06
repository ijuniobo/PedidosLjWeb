using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PedidosLjWeb.Domain.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosLjWeb.Repository.Mapping
{
    public class LojaMapping : IEntityTypeConfiguration<Loja>
    {
        public void Configure(EntityTypeBuilder<Loja> builder)
        {
            builder.ToTable(nameof(Loja));

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(1000);
            builder.Property(x => x.Fantasia).IsRequired().HasMaxLength(1000);
            builder.Property(x => x.Endereco).IsRequired().HasMaxLength(2000);
            builder.Property(x => x.Cidade).IsRequired().HasMaxLength(2000);
            builder.Property(x => x.Bairro).IsRequired().HasMaxLength(2000);
            builder.Property(x => x.Estado).IsRequired().HasMaxLength(2);
            builder.Property(x => x.Cnpj).IsRequired().HasMaxLength(100);

            builder.HasMany(x => x.Pedidos).WithOne().OnDelete(DeleteBehavior.Cascade);

        }
    }
}
