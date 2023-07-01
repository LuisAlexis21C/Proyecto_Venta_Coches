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
    public partial class Frm_gestionarUser : Form
    {
        public Frm_gestionarUser()
        {
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Frm_usuario_nuevo us = new Frm_usuario_nuevo();
            us.ShowDialog();

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            
          
            dgv_user.Rows.Add(txt_nombre.Text, txt_apellido.Text, txt_carnet.Text, cb_rol.Text,txt_nomuser.Text ,txt_direccion.Text, txt_celular.Text , txt_edad.Text, cb_gnero.Text);
        }

        private void btn_sal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult res = MessageBox.Show("¿Estas seguro de que quieres eliminar estos datos?","Eliminar datos",botones,MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes) {
                if (dgv_user.Rows.Count > 1)
                {
                    if (dgv_user.CurrentRow.Index != dgv_user.Rows.Count - 1)
                    {
                        dgv_user.Rows.RemoveAt(dgv_user.CurrentRow.Index);
                    }
                }
                else { 
                    Close();    
                }
            }
        }

        private void btn_vol_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgv_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_nomuser.Text = "";
            txt_direccion.Text = "";
            txt_carnet.Text = "";
            txt_celular.Text = "";
            cb_gnero.Text = "";
            txt_edad.Text = "";
            cb_rol.Text = "";

        }

        private void dgv_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_nombre.Text = dgv_user.CurrentRow.Cells[0].Value.ToString();
            txt_apellido.Text = dgv_user.CurrentRow.Cells[1].Value.ToString();
            txt_carnet.Text = dgv_user.CurrentRow.Cells[2].Value.ToString();
            txt_direccion.Text = dgv_user.CurrentRow.Cells[3].Value.ToString();
            txt_celular.Text = dgv_user.CurrentRow.Cells[4].Value.ToString();
            cb_gnero.Text = dgv_user.CurrentRow.Cells[5].Value.ToString();
            txt_edad.Text = dgv_user.CurrentRow.Cells[6].Value.ToString();
            txt_nomuser.Text = dgv_user.CurrentRow.Cells[7].Value.ToString();
            cb_rol.Text = dgv_user.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
