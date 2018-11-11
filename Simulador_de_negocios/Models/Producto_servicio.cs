using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Simulador_de_negocios.Models
{
    public class Producto_servicio
    {
        [Key]
        public int id_producto { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(65, MinimumLength = 1, ErrorMessage = "El nombre debe de tener de 1 a 65 caracteres")]
        public String nombre_producto { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(45, MinimumLength = 3, ErrorMessage = "La unidad de produccion debe de tener de 3 a 45 caracteres")]
        public String unidad_produccion { get; set; }

        public Int32 produccion_mensual { get; set; }

        public Double costo_unitario { get; set; }

        public Double margen_utilidad { get; set; }

        public Double precio_publico { get; set; }

        public Int32 datos_empresa_id_empresa { get; set; }
    }
}
