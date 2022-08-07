using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Data.Models;

namespace Vuelos.Data
{
    public class EjercicioVuelosContext : DbContext
    {
        public EjercicioVuelosContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Vuelo> Vuelos { get; set; }
    }
}
