using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simulador_de_negocios.Models;

namespace Simulador_de_negocios.Data
{
        public class DbInitializer
        {
            public static void Initialize(Simulador_de_negociosContext context)
            {
                context.Database.EnsureCreated();
                if (context.Producto_servicio.Any())
                {
                    return;
                }
                var producto_servicio = new Producto_servicio[]
                {
                    //new Alumno {Nombres="Leonel", ApellidoP="Gonzalez", ApellidoM ="Vidales", Edad =20, NumTelefono = "7321080568", Domicilio = "Av. Pungarabato Pte S/N", Colonia="Morelos", Ciudad ="Cd. Altamirano", CP =40660, Estado ="Guerrero"}
                };

                foreach (Producto_servicio a in producto_servicio)
                {
                    context.Producto_servicio.Add(a);

                }
                context.SaveChanges();

            }
        }
    }

