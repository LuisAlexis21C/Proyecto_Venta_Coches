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
    public partial class Frm_Registrar_venta : Form
    {
        public Frm_Registrar_venta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Recibo frm_Recibo = new Frm_Recibo();   
            frm_Recibo.ShowDialog();
        }
    }
}
