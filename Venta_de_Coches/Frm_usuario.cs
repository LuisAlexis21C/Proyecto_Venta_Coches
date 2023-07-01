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
            Frm_gestionarUser us = new Frm_gestionarUser();
            us.ShowDialog();
        }
    }
}
