using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_de_Coches.Models
{
    public class Automovil
    {
        [Key]
        public string Codigo { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string Cilindrada { get; set; }
        [Required]
        public string Combustible { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public int Modelo { get; set; }
        [Required]
        public string Fabricacion { get; set; }
        [Required]
        public int Precio_Compra { get; set; }
        public string Detalle { get; set; }
        [Required]
        public int Puertas { get; set; }
        [Required]
        public int Estado { get; set; }
        virtual public List<Venta> Ventas { get; set; }

    }
}
