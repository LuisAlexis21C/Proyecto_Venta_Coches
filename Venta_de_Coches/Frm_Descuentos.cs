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
    public partial class Frm_Descuentos : Form
    {
        public Frm_Descuentos()
        {
            InitializeComponent();
        }

        private void btn_is_Click(object sender, EventArgs e)
        {
            Frm_verificacion frm_Verificacion = new Frm_verificacion();
            frm_Verificacion.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_buscar frm_Buscar = new Frm_buscar();   
            frm_Buscar.ShowDialog();
        }
    }
}
