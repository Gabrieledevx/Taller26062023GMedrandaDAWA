using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller26062023GMedrandaDAWA.Models;

namespace Taller26062023GMedrandaDAWA.Models
{
    public class AplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=namedb;User Id=postgres;Password=clave;");
            }
        }
        public DbSet<Cliente> Cliente { get; set; }

        public AplicationDbContext(DbSet<Cliente> cliente)
        {
            Cliente = cliente;
        }
    }
}