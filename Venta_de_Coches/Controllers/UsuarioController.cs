using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta_de_Coches.Context;
using Venta_de_Coches.Models;

namespace Venta_de_Coches.Controllers
{
    internal class UsuarioController
    {
        CochesContext _context = new CochesContext();
        public bool Login(string codigo, string password) { 
           List<Usuario>  usuarios = _context.Usuario.Where(x => x.Codigo == codigo && x.Contraseña == password).ToList();
            if (usuarios.Count() > 0)
                return true;
            return false;   
        }
    }
}
