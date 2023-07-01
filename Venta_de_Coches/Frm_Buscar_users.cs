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
    public partial class Frm_Buscar_users : Form
    {
        public Frm_Buscar_users()
        {
            InitializeComponent();
        }

        private void btn_vol_Click(object sender, EventArgs e)
        {
            Frm_Principal frm_Principal = new Frm_Principal();
            frm_Principal.ShowDialog();
        }

        private void btn_sal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
