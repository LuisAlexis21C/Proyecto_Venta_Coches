using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using Venta_de_Coches.Models;

namespace Venta_de_Coches.Context
{
    public partial class CochesContext : DbContext
    {
        public CochesContext()
            : base("name=CochesContext")
        {
        }
        //Estp se convertira en tabla en SQL
        virtual public DbSet<Usuario>  Usuario { get; set; }
        virtual public DbSet<Automovil> Automovil { get; set; }
        virtual public DbSet<Cliente> Cliente { get; set; }
        virtual public DbSet<PagoCredito> PagoCredito { get; set; }
        virtual public DbSet<Venta> Venta { get; set; }
        
    }
}
