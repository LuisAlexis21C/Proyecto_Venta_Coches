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
            Frm_buscar busca = new Frm_buscar();
            busca.ShowDialog();
        }

        private void gESTIONARVEHICULOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CochesGestionar frm_Coches = new Frm_CochesGestionar(); 
            frm_Coches.ShowDialog();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void gENERARRECIBOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Recibo recibo = new Frm_Recibo();   
            recibo.ShowDialog();
        }

        private void rEALIZARCOMPRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Registrar_venta venta = new Frm_Registrar_venta();
            venta.ShowDialog(); 
        }

        private void nUEVOCOCHEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_nuevo nuevo = new Frm_nuevo();  
            nuevo.ShowDialog();
        }

        private void gESTIONARUSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_gestionarUser user = new Frm_gestionarUser();
            user.ShowDialog();
        }
    }
}
