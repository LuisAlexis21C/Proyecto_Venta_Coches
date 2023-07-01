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
            Dgv_coche.Rows.Add(txt_codigo.Text, txt_marca.Text, txt_modelo.Text, txt_color.Text, txt_cilindra.Text,txt_combustible.Text, txt_tipo.Text,txt_fabricacion.Text,cb_transision.Text, txt_precio.Text);
        }


        private void btn_sal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_vol_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txt_color.Text = "";
            txt_codigo.Text = "";
            txt_marca.Text = "";
            txt_modelo.Text = "";
            txt_combustible.Text = "";
            txt_cilindra.Text = "";
            txt_tipo.Text = "";
            txt_fabricacion.Text = "";
            cb_transision.Text = "";
            txt_precio.Text = "";
        }

        private void Dgv_coche_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo.Text = Dgv_coche.CurrentRow.Cells[0].Value.ToString();
            txt_marca.Text = Dgv_coche.CurrentRow.Cells[1].Value.ToString();
            txt_modelo.Text = Dgv_coche.CurrentRow.Cells[2].Value.ToString();
            txt_color.Text = Dgv_coche.CurrentRow.Cells[3].Value.ToString();
            txt_combustible.Text = Dgv_coche.CurrentRow.Cells[4].Value.ToString();
            txt_cilindra.Text = Dgv_coche.CurrentRow.Cells[5].Value.ToString();
            txt_tipo.Text = Dgv_coche.CurrentRow.Cells[6].Value.ToString();
            txt_fabricacion.Text = Dgv_coche.CurrentRow.Cells[7].Value.ToString();
            cb_transision.Text = Dgv_coche.CurrentRow.Cells[8].Value.ToString();
            txt_precio.Text = Dgv_coche.CurrentRow.Cells[9].Value.ToString();
        }

        private void Dgv_coche_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
