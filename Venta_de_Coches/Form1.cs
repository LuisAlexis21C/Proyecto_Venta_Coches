using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Venta_de_Coches.Context;
using Venta_de_Coches.Controllers;

namespace Venta_de_Coches
{
    public partial class Frm_verificacion : Form
    {
        public Frm_verificacion()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_acceder_Click(object sender, EventArgs e)
        {  
            Frm_Principal principal = new Frm_Principal();
            UsuarioController controller = new UsuarioController();

            string cuenta = txt_user.Text;
            string passw = txt_contra.Text;
            if (controller.Login(cuenta, passw))
            {
                MessageBox.Show("Bienvenido al sistema Gerente");
                principal.ShowDialog();
            }
            else
                MessageBox.Show("No tienes acceso");
        }

        private void Frm_verificacion_Load(object sender, EventArgs e)
        {
            //CochesContext cochesContext = new CochesContext();
            //cochesContext.Usuario.ToList();
           // cochesContext.Automovil.ToList();
            //cochesContext.Cliente.ToList();
            //cochesContext.PagoCredito.ToList();
           // cochesContext.Venta.ToList();
        }
    }
}
