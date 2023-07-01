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
            Frm_NewCoche nuevo = new Frm_NewCoche();  
            nuevo.ShowDialog();
        }

        private void gESTIONARUSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_gestionarUser user = new Frm_gestionarUser();
            user.ShowDialog();
        }
        private void AbrirFrom(object formSec) {
            if (this.panelC.Controls.Count > 0) { 
              this.panelC.Controls.RemoveAt(0);
                Form fh = formSec as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelC.Controls.Add(fh);
                this.panelC.Tag = fh;
                fh.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Frm_NewCoche frm_NewCoche = new Frm_NewCoche();
            frm_NewCoche.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_Registrar_venta venta = new Frm_Registrar_venta();
            venta.ShowDialog(),
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm_Recibo rec = new Frm_Recibo();  
            rec.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frm_reporte rep = new Frm_reporte();
            rep.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_buscar buscar = new Frm_buscar();
            buscar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_gestionarUser usr = new Frm_gestionarUser();
            usr.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_CochesGestionar coh = new Frm_CochesGestionar();
            coh.ShowDialog();
        }
    }
}
