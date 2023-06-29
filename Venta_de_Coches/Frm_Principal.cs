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
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void bUSCARVEHICULOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gESTIONARVEHICULOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CochesGestionar frm_Coches = new Frm_CochesGestionar(); 
            frm_Coches.ShowDialog();
        }
    }
}
