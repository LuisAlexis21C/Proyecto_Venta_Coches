namespace Venta_de_Coches
{
    partial class Frm_Uno
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_acceder = new System.Windows.Forms.Button();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_contra = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_contra = new System.Windows.Forms.TextBox();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Location = new System.Drawing.Point(345, 363);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(97, 36);
            this.Btn_Salir.TabIndex = 1;
            this.Btn_Salir.Text = "SALIR";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_acceder
            // 
            this.Btn_acceder.Location = new System.Drawing.Point(173, 363);
            this.Btn_acceder.Name = "Btn_acceder";
            this.Btn_acceder.Size = new System.Drawing.Size(97, 36);
            this.Btn_acceder.TabIndex = 2;
            this.Btn_acceder.Text = "ACCEDER";
            this.Btn_acceder.UseVisualStyleBackColor = true;
            this.Btn_acceder.Click += new System.EventHandler(this.Btn_acceder_Click);
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(132, 260);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(75, 23);
            this.lbl_user.TabIndex = 3;
            this.lbl_user.Text = "Usuario:";
            // 
            // lbl_contra
            // 
            this.lbl_contra.AutoSize = true;
            this.lbl_contra.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contra.Location = new System.Drawing.Point(132, 312);
            this.lbl_contra.Name = "lbl_contra";
            this.lbl_contra.Size = new System.Drawing.Size(107, 23);
            this.lbl_contra.TabIndex = 4;
            this.lbl_contra.Text = "Contraseña:";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(247, 265);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(239, 20);
            this.txt_user.TabIndex = 5;
            // 
            // txt_contra
            // 
            this.txt_contra.Location = new System.Drawing.Point(247, 312);
            this.txt_contra.Name = "txt_contra";
            this.txt_contra.PasswordChar = '*';
            this.txt_contra.Size = new System.Drawing.Size(239, 20);
            this.txt_contra.TabIndex = 6;
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.ForeColor = System.Drawing.Color.Red;
            this.Lbl_titulo.Location = new System.Drawing.Point(256, 23);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(149, 36);
            this.Lbl_titulo.TabIndex = 7;
            this.Lbl_titulo.Text = "BIENVENIDO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(220, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 166);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Frm_Uno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lbl_titulo);
            this.Controls.Add(this.txt_contra);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lbl_contra);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.Btn_acceder);
            this.Controls.Add(this.Btn_Salir);
            this.Name = "Frm_Uno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Verificacion de Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_acceder;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_contra;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_contra;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

