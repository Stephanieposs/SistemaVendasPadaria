using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaVendasPadaria.Models;

namespace SistemaVendasPadaria.Data
{
    public class SistemaVendasPadariaContext : DbContext
    {
        public SistemaVendasPadariaContext (DbContextOptions<SistemaVendasPadariaContext> options)
            : base(options)
        {
        }

        public DbSet<SistemaVendasPadaria.Models.ClienteRegistrado> ClienteRegistrado { get; set; } = default!;
        public DbSet<SistemaVendasPadaria.Models.Produto> Produto { get; set; } = default!;
        public DbSet<SistemaVendasPadaria.Models.ItemVenda> ItemVendas { get; set; } = default!;
        public DbSet<SistemaVendasPadaria.Models.Venda> Vendas { get; set; } = default!;
    }
}
