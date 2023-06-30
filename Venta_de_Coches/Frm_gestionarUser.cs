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
            Frm_usuario_nuevo user = new Frm_usuario_nuevo();
            user.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string genero, rol;
            if (Rb_mac.Checked == true)
            {
                genero = "Masculino";
            }
            else
            {
                if (Rb_fem.Checked == true)
                {
                    genero = "Femenino";
                }
                else
                {

                    genero = "Sin Especificar";
                }
            }

            if (rb_grt.Checked == true)
            {
                rol = "Gerente";
            }
            else
            {
                if (Rb_fem.Checked == true)
                {
                    rol = "Vendedor";
                }
                else
                {

                    rol = "Personal";
                }
            }

            dgv_user.Rows.Add(txt_nombre.Text, txt_apellido.Text, txt_carnet.Text, rol, genero, txt_nomuser.Text, txt_direccion.Text, txt_celular.Text, txt_edad.Text, genero);
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
    }
}
