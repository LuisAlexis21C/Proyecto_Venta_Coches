using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta_de_Coches.Models
{
    public class Venta
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Precio_Venta { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public DateTime Hora { get; set; }
        [Required]
        public string Tipo_Pago { get; set; }
        public int Detalle { get; set; }

        virtual public List <PagoCredito> PagoCredito { get; set;}
        virtual public Usuario Usuario { get; set; }
        virtual public List<Cliente> Clientes { get; set; }
        virtual public Automovil Automovil { get; set; }

    }
}
