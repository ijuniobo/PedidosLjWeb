using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PedidosLjWeb.Domain.Pedidos;

namespace PedidosLjWeb.Repository.Mapping
{



    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable(nameof(Cliente));

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(1000);
            builder.Property(x => x.Endereco).IsRequired().HasMaxLength(2000);
            builder.Property(x => x.Cidade).IsRequired().HasMaxLength(2000);
            builder.Property(x => x.Bairro).IsRequired().HasMaxLength(2000);
            builder.Property(x => x.Estado).IsRequired().HasMaxLength(2);
            builder.Property(x => x.Complemento).IsRequired().HasMaxLength(1000);
            builder.Property(x => x.Cep).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Cpf).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Cnpj).IsRequired().HasMaxLength(100);
            builder.Property(x => x.TipoPessoa).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Login).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Senha).IsRequired().HasMaxLength(100);

            builder.HasMany(x => x.Pedidos).WithOne();

        }
    }

}
