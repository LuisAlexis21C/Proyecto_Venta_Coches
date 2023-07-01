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
    public partial class Frm_CochesGestionar : Form
    {
        public Frm_CochesGestionar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_NewCoche aut = new Frm_NewCoche();
            aut.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult res = MessageBox.Show("¿Estas seguro de que quieres eliminar estos datos?", "Eliminar datos", botones, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                if (Dgv_coche.Rows.Count > 1)
                {
                    if (Dgv_coche.CurrentRow.Index != Dgv_coche.Rows.Count - 1)
                    {
                        Dgv_coche.Rows.RemoveAt(Dgv_coche.CurrentRow.Index);
                    }
                }
                else
                {
                    Close();
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Dgv_coche.Rows.Add(txt_codigo.Text, txt_marca.Text, txt_modelo.Text, txt_color.Text,txt_combustible.Text,txt_cilindra.Text, txt_tipo.Text,txt_fabricacion.Text,cb_transision, txt_precio.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_sal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_vol_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
