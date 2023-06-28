using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venta_de_Coches
{
    public partial class Frm_Uno : Form
    {
        public Frm_Uno()
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
        {   Frm_Principal principal = new Frm_Principal();
            string cuenta = txt_user.Text;
            string passw = txt_contra.Text;
            if (cuenta == "GRT_123" && passw == "987")
            {
                MessageBox.Show("Bienvenido al sistema Gerente");
                principal.ShowDialog();
            }
            else
                MessageBox.Show("No tienes acceso");
        }
    }
}
