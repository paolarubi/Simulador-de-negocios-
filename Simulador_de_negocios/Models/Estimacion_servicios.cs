using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Simulador_de_negocios.Models
{
    public class Estimacion_servicios
    {
        [Key]

        public Int32 id_suscripcion { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(45, MinimumLength = 1, ErrorMessage = "La unidad de produccion debe de tener de 1 a 45 caracteres")]
        public String unidad_produccion { get; set; }

        public Int32 total_suscripciones { get; set; }

        public Double total_mensual { get; set; }

        public Int32 producto_servicios_id_producto { get; set; }
    }
}
