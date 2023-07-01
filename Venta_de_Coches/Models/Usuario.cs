using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Venta_de_Coches.Models
{
    public class Usuario
    {
        [Key]
        public string Codigo { get; set; }
        [Required]
        public string Contraseña { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Rol { get; set; }
        [Required]
        public string Carnet { get; set; }

        virtual public List<Venta> Ventas { get; set; }

    }
}
