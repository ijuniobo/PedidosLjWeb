using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PedidosLjWeb.Domain.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PedidosLjWeb.Repository
{
    public class PedidosLjWebContext : DbContext
    {
        public DbSet<Loja> Loja { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<ItemPedido> ItemPedido { get; set; }
        public DbSet<Produto> Produto { get; set; }

        public PedidosLjWebContext(DbContextOptions<PedidosLjWebContext> options) : base(options)
        {

        }


        //Escrever protected internal e vai aparecer OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PedidosLjWebContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(LoggerFactory.Create(x => x.AddConsole()));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
