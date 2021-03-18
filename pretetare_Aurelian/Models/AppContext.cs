using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace pretetare_Aurelian.Models
{
    class AppContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=City;Trusted_Connection=True;");
        }
        public DbSet<Pasager> Pasageri { get; set; }
        public DbSet<Ruta> Rute { get; set; }
    }
}
