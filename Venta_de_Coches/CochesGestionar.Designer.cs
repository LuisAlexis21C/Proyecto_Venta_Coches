﻿namespace Venta_de_Coches
{
    partial class Frm_CochesGestionar
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Dgv_coche = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_vol = new System.Windows.Forms.Button();
            this.btn_sal = new System.Windows.Forms.Button();
            this.cb_transision = new System.Windows.Forms.ComboBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_fabricacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cilindra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_combustible = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_color = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CILINDRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMBUSTIBLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FABRICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANSMISION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_coche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUSQUEDA DE AUTOS POR: MARCA | MODELO | TIPO | CODIGO";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.LightGoldenrodYellow;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Yellow;
            this.dateTimePicker1.Location = new System.Drawing.Point(879, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // Dgv_coche
            // 
            this.Dgv_coche.AllowUserToOrderColumns = true;
            this.Dgv_coche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_coche.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.MARC,
            this.MODELO,
            this.COLOR,
            this.CILINDRADA,
            this.COMBUSTIBLE,
            this.TIPO,
            this.FABRICACION,
            this.TRANSMISION,
            this.PRECIO});
            this.Dgv_coche.Location = new System.Drawing.Point(7, 113);
            this.Dgv_coche.Name = "Dgv_coche";
            this.Dgv_coche.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_coche.Size = new System.Drawing.Size(1013, 224);
            this.Dgv_coche.TabIndex = 4;
            this.Dgv_coche.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_coche_CellClick);
            this.Dgv_coche.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_coche_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(424, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "OPCIONES";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(354, 385);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(106, 38);
            this.btn_nuevo.TabIndex = 6;
            this.btn_nuevo.Text = "NUEVO";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(230, 386);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(106, 38);
            this.btn_eliminar.TabIndex = 7;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(1065, 455);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(106, 38);
            this.btn_edit.TabIndex = 8;
            this.btn_edit.Text = "ACTUALIZAR";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_vol
            // 
            this.btn_vol.Location = new System.Drawing.Point(477, 385);
            this.btn_vol.Name = "btn_vol";
            this.btn_vol.Size = new System.Drawing.Size(106, 38);
            this.btn_vol.TabIndex = 9;
            this.btn_vol.Text = "VOLVER";
            this.btn_vol.UseVisualStyleBackColor = true;
            this.btn_vol.Click += new System.EventHandler(this.btn_vol_Click);
            // 
            // btn_sal
            // 
            this.btn_sal.Location = new System.Drawing.Point(601, 385);
            this.btn_sal.Name = "btn_sal";
            this.btn_sal.Size = new System.Drawing.Size(106, 38);
            this.btn_sal.TabIndex = 10;
            this.btn_sal.Text = "SALIR";
            this.btn_sal.UseVisualStyleBackColor = true;
            this.btn_sal.Click += new System.EventHandler(this.btn_sal_Click);
            // 
            // cb_transision
            // 
            this.cb_transision.FormattingEnabled = true;
            this.cb_transision.Items.AddRange(new object[] {
            "Automatica",
            "Manual"});
            this.cb_transision.Location = new System.Drawing.Point(1155, 385);
            this.cb_transision.Name = "cb_transision";
            this.cb_transision.Size = new System.Drawing.Size(149, 21);
            this.cb_transision.TabIndex = 74;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(1155, 420);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(203, 20);
            this.txt_precio.TabIndex = 71;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1026, 417);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 70;
            this.label9.Text = "Precio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1026, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 69;
            this.label8.Text = "Transmision:";
            // 
            // txt_fabricacion
            // 
            this.txt_fabricacion.Location = new System.Drawing.Point(1155, 349);
            this.txt_fabricacion.Name = "txt_fabricacion";
            this.txt_fabricacion.Size = new System.Drawing.Size(203, 20);
            this.txt_fabricacion.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1026, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 67;
            this.label7.Text = "Fabricacion:";
            // 
            // txt_tipo
            // 
            this.txt_tipo.Location = new System.Drawing.Point(1155, 313);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Size = new System.Drawing.Size(203, 20);
            this.txt_tipo.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1026, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 65;
            this.label6.Text = "Tipo:";
            // 
            // txt_cilindra
            // 
            this.txt_cilindra.Location = new System.Drawing.Point(1155, 278);
            this.txt_cilindra.Name = "txt_cilindra";
            this.txt_cilindra.Size = new System.Drawing.Size(203, 20);
            this.txt_cilindra.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1026, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 63;
            this.label4.Text = "Cilindrada:";
            // 
            // txt_combustible
            // 
            this.txt_combustible.Location = new System.Drawing.Point(1155, 243);
            this.txt_combustible.Name = "txt_combustible";
            this.txt_combustible.Size = new System.Drawing.Size(203, 20);
            this.txt_combustible.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1026, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 61;
            this.label5.Text = "Combustible:";
            // 
            // txt_color
            // 
            this.txt_color.Location = new System.Drawing.Point(1155, 209);
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(203, 20);
            this.txt_color.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1026, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "Color:";
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(1155, 173);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(203, 20);
            this.txt_modelo.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1026, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 57;
            this.label10.Text = "Modelo:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(1155, 101);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(203, 20);
            this.txt_codigo.TabIndex = 56;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1026, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 20);
            this.label13.TabIndex = 55;
            this.label13.Text = "Codigo:";
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(1155, 136);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(203, 20);
            this.txt_marca.TabIndex = 76;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1026, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 75;
            this.label11.Text = "Marca:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(1120, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 29);
            this.label12.TabIndex = 77;
            this.label12.Text = "DATOS DEL COCHE";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1217, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 38);
            this.button2.TabIndex = 78;
            this.button2.Text = "NUEVO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Venta_de_Coches.Properties.Resources.motors;
            this.pictureBox1.Location = new System.Drawing.Point(719, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.MaxInputLength = 32750;
            this.CODIGO.Name = "CODIGO";
            // 
            // MARC
            // 
            this.MARC.HeaderText = "MARCA";
            this.MARC.Name = "MARC";
            // 
            // MODELO
            // 
            this.MODELO.HeaderText = "MODELO";
            this.MODELO.Name = "MODELO";
            // 
            // COLOR
            // 
            this.COLOR.HeaderText = "COLOR";
            this.COLOR.Name = "COLOR";
            // 
            // CILINDRADA
            // 
            this.CILINDRADA.HeaderText = "CILINDRADA";
            this.CILINDRADA.Name = "CILINDRADA";
            // 
            // COMBUSTIBLE
            // 
            this.COMBUSTIBLE.HeaderText = "COMBUSTIBLE";
            this.COMBUSTIBLE.Name = "COMBUSTIBLE";
            // 
            // TIPO
            // 
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            // 
            // FABRICACION
            // 
            this.FABRICACION.HeaderText = "FABRICACION";
            this.FABRICACION.Name = "FABRICACION";
            // 
            // TRANSMISION
            // 
            this.TRANSMISION.HeaderText = "TRANSMISION";
            this.TRANSMISION.Name = "TRANSMISION";
            // 
            // PRECIO
            // 
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            // 
            // Frm_CochesGestionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1370, 505);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_marca);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cb_transision);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_fabricacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_tipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_cilindra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_combustible);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_color);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_modelo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_sal);
            this.Controls.Add(this.btn_vol);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dgv_coche);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_CochesGestionar";
            this.Text = "Control Coches";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_coche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_vol;
        private System.Windows.Forms.Button btn_sal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cb_transision;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_fabricacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_tipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cilindra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_combustible;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_color;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.DataGridView Dgv_coche;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CILINDRADA;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMBUSTIBLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FABRICACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANSMISION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
    }
}