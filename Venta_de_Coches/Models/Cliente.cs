using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_de_Coches.Models
{
    public class Cliente
    {
        [Key]
        public string Carnet { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Celular { get; set; }
        public string Direccion { get; set; }

        virtual public List<Venta> Ven { get; set; }
    }
}
