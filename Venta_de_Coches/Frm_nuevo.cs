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
    public partial class Frm_NewCoche : Form
    {
        public Frm_NewCoche()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_CochesGestionar Pa = new Frm_CochesGestionar();
          
            Pa.Dgv_coche.Rows.Add(txt_cod2.Text,txt_marca2.Text,txt_mode2.Text,txt_color2.Text,txt_cilin2.Text, txt_combus2.Text,txt_tipo2.Text,txt_fab2.Text,cb_tran2.Text,txt_preV2.Text);
            this.Dispose();
            Pa.ShowDialog();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
