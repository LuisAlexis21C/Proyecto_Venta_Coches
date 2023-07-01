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
    public partial class Frm_usuario_nuevo : Form
    {
        public Frm_usuario_nuevo()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_usuario_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cb_gnero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_gestionarUser ur = new Frm_gestionarUser();
            ur.dgv_user.Rows.Add(txt_nombre2.Text, txt_apellido2.Text, txt_Carnet2.Text, cb_rol2.Text, txt_nomuser2.Text, txt_direccion2.Text, txt_celular2.Text, txt_edad2.Text, cb_gnero2.Text);
            this.Dispose();
            ur.ShowDialog();
        }
    }
}
