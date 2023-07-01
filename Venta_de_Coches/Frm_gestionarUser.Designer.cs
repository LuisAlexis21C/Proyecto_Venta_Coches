namespace Venta_de_Coches
{
    partial class Frm_gestionarUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_sal = new System.Windows.Forms.Button();
            this.btn_vol = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nomuser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Rb_fem = new System.Windows.Forms.RadioButton();
            this.Rb_mac = new System.Windows.Forms.RadioButton();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_celular = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_carnet = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rb_vnd = new System.Windows.Forms.RadioButton();
            this.rb_grt = new System.Windows.Forms.RadioButton();
            this.btn_nuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sal
            // 
            this.btn_sal.Location = new System.Drawing.Point(728, 384);
            this.btn_sal.Name = "btn_sal";
            this.btn_sal.Size = new System.Drawing.Size(106, 38);
            this.btn_sal.TabIndex = 22;
            this.btn_sal.Text = "SALIR";
            this.btn_sal.UseVisualStyleBackColor = true;
            this.btn_sal.Click += new System.EventHandler(this.btn_sal_Click);
            // 
            // btn_vol
            // 
            this.btn_vol.Location = new System.Drawing.Point(603, 384);
            this.btn_vol.Name = "btn_vol";
            this.btn_vol.Size = new System.Drawing.Size(106, 38);
            this.btn_vol.TabIndex = 21;
            this.btn_vol.Text = "VOLVER";
            this.btn_vol.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(1067, 429);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(106, 38);
            this.btn_guardar.TabIndex = 20;
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(473, 384);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(106, 38);
            this.btn_eliminar.TabIndex = 19;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(422, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "OPCIONES:";
            // 
            // dgv_user
            // 
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.AP,
            this.CA,
            this.RO,
            this.NS,
            this.DI,
            this.CE,
            this.ED,
            this.GE});
            this.dgv_user.Location = new System.Drawing.Point(16, 116);
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.Size = new System.Drawing.Size(942, 224);
            this.dgv_user.TabIndex = 16;
            // 
            // nom
            // 
            this.nom.HeaderText = "NOMBRE";
            this.nom.Name = "nom";
            // 
            // AP
            // 
            this.AP.HeaderText = "APELLIDO";
            this.AP.Name = "AP";
            // 
            // CA
            // 
            this.CA.HeaderText = "CARNET";
            this.CA.Name = "CA";
            // 
            // RO
            // 
            this.RO.HeaderText = "ROL";
            this.RO.Name = "RO";
            // 
            // NS
            // 
            this.NS.HeaderText = "N. USUARIO";
            this.NS.Name = "NS";
            // 
            // DI
            // 
            this.DI.HeaderText = "DIRECCION";
            this.DI.Name = "DI";
            // 
            // CE
            // 
            this.CE.HeaderText = "CELULAR";
            this.CE.Name = "CE";
            // 
            // ED
            // 
            this.ED.HeaderText = "EDAD";
            this.ED.Name = "ED";
            // 
            // GE
            // 
            this.GE.HeaderText = "GENERO";
            this.GE.Name = "GE";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.LightGoldenrodYellow;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Yellow;
            this.dateTimePicker1.Location = new System.Drawing.Point(888, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 20);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "BUSQUEDA DE USUARIOS POR: NOMBRE | CARNET | CELULAR | EDAD";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Venta_de_Coches.Properties.Resources.motors;
            this.pictureBox1.Location = new System.Drawing.Point(728, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(992, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 20);
            this.label10.TabIndex = 85;
            this.label10.Text = "Rol:";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(1121, 142);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(203, 20);
            this.txt_apellido.TabIndex = 84;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(992, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 83;
            this.label9.Text = "Apellido:";
            // 
            // txt_nomuser
            // 
            this.txt_nomuser.Location = new System.Drawing.Point(1121, 356);
            this.txt_nomuser.Name = "txt_nomuser";
            this.txt_nomuser.Size = new System.Drawing.Size(203, 20);
            this.txt_nomuser.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(992, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 79;
            this.label7.Text = "Nombre Usuario:";
            // 
            // Rb_fem
            // 
            this.Rb_fem.AutoSize = true;
            this.Rb_fem.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_fem.Location = new System.Drawing.Point(1249, 286);
            this.Rb_fem.Name = "Rb_fem";
            this.Rb_fem.Size = new System.Drawing.Size(104, 25);
            this.Rb_fem.TabIndex = 78;
            this.Rb_fem.TabStop = true;
            this.Rb_fem.Text = "Femenino";
            this.Rb_fem.UseVisualStyleBackColor = true;
            // 
            // Rb_mac
            // 
            this.Rb_mac.AutoSize = true;
            this.Rb_mac.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rb_mac.Location = new System.Drawing.Point(1121, 286);
            this.Rb_mac.Name = "Rb_mac";
            this.Rb_mac.Size = new System.Drawing.Size(106, 25);
            this.Rb_mac.TabIndex = 77;
            this.Rb_mac.TabStop = true;
            this.Rb_mac.Text = "Masculino";
            this.Rb_mac.UseVisualStyleBackColor = true;
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(1121, 320);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(203, 20);
            this.txt_edad.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(992, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 75;
            this.label4.Text = "Edad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(992, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 74;
            this.label6.Text = "Genero:";
            // 
            // txt_celular
            // 
            this.txt_celular.Location = new System.Drawing.Point(1121, 250);
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(203, 20);
            this.txt_celular.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(992, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 72;
            this.label5.Text = "Celular:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(1121, 216);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(203, 20);
            this.txt_direccion.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(992, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "Direccion:";
            // 
            // txt_carnet
            // 
            this.txt_carnet.Location = new System.Drawing.Point(1121, 180);
            this.txt_carnet.Name = "txt_carnet";
            this.txt_carnet.Size = new System.Drawing.Size(203, 20);
            this.txt_carnet.TabIndex = 69;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(992, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.TabIndex = 68;
            this.label11.Text = "Carnet:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(1121, 104);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(203, 20);
            this.txt_nombre.TabIndex = 67;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(992, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 20);
            this.label12.TabIndex = 66;
            this.label12.Text = "Nombre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(1116, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 29);
            this.label8.TabIndex = 87;
            this.label8.Text = "INFORMACION";
            // 
            // rb_vnd
            // 
            this.rb_vnd.AutoSize = true;
            this.rb_vnd.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_vnd.Location = new System.Drawing.Point(1249, 389);
            this.rb_vnd.Name = "rb_vnd";
            this.rb_vnd.Size = new System.Drawing.Size(103, 25);
            this.rb_vnd.TabIndex = 89;
            this.rb_vnd.TabStop = true;
            this.rb_vnd.Text = "Vendedor";
            this.rb_vnd.UseVisualStyleBackColor = true;
            // 
            // rb_grt
            // 
            this.rb_grt.AutoSize = true;
            this.rb_grt.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_grt.Location = new System.Drawing.Point(1121, 389);
            this.rb_grt.Name = "rb_grt";
            this.rb_grt.Size = new System.Drawing.Size(89, 25);
            this.rb_grt.TabIndex = 88;
            this.rb_grt.TabStop = true;
            this.rb_grt.Text = "Gerente";
            this.rb_grt.UseVisualStyleBackColor = true;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(361, 384);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(106, 38);
            this.btn_nuevo.TabIndex = 18;
            this.btn_nuevo.Text = "NUEVO";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // Frm_gestionarUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1370, 494);
            this.Controls.Add(this.rb_vnd);
            this.Controls.Add(this.rb_grt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_nomuser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Rb_fem);
            this.Controls.Add(this.Rb_mac);
            this.Controls.Add(this.txt_edad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_celular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_carnet);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_sal);
            this.Controls.Add(this.btn_vol);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_user);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_gestionarUser";
            this.Text = "Frm_gestionarUser";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_sal;
        private System.Windows.Forms.Button btn_vol;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_user;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn AP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CA;
        private System.Windows.Forms.DataGridViewTextBoxColumn RO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ED;
        private System.Windows.Forms.DataGridViewTextBoxColumn GE;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_nomuser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton Rb_fem;
        private System.Windows.Forms.RadioButton Rb_mac;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_celular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_carnet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rb_vnd;
        private System.Windows.Forms.RadioButton rb_grt;
        private System.Windows.Forms.Button btn_nuevo;
    }
}