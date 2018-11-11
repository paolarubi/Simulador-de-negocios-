using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Simulador_de_negocios.Models;

namespace Simulador_de_negocios.Models
{
    public class Simulador_de_negociosContext : DbContext
    {
        public Simulador_de_negociosContext (DbContextOptions<Simulador_de_negociosContext> options)
            : base(options)
        {
        }

        public DbSet<Simulador_de_negocios.Models.Producto_servicio> Producto_servicio { get; set; }

        public DbSet<Simulador_de_negocios.Models.Estimacion_servicios> Estimacion_servicios { get; set; }
    }
}
