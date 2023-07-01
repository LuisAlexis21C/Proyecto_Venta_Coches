using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_de_Coches.Models
{
    public class PagoCredito
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public int Monto_Pago { get; set; }
        [Required]
        public string Nombre_Completo { get; set; }
        [Required]
        public string Codigo_Coche { get; set; }
        [Required]
        public string Carnet_Cliente { get; set; }

        virtual public Venta Venta { get; set; }
    }
}
