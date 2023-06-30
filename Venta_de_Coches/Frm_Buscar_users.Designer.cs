namespace Venta_de_Coches
{
    partial class Frm_Buscar_users
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sal
            // 
            this.btn_sal.Location = new System.Drawing.Point(972, 167);
            this.btn_sal.Name = "btn_sal";
            this.btn_sal.Size = new System.Drawing.Size(106, 38);
            this.btn_sal.TabIndex = 34;
            this.btn_sal.Text = "SALIR";
            this.btn_sal.UseVisualStyleBackColor = true;
            // 
            // btn_vol
            // 
            this.btn_vol.Location = new System.Drawing.Point(972, 123);
            this.btn_vol.Name = "btn_vol";
            this.btn_vol.Size = new System.Drawing.Size(106, 38);
            this.btn_vol.TabIndex = 33;
            this.btn_vol.Text = "VOLVER";
            this.btn_vol.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(967, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 29);
            this.label2.TabIndex = 29;
            this.label2.Text = "OPCIONES:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.AP,
            this.CA,
            this.RO,
            this.NS,
            this.DI,
            this.CE,
            this.ED,
            this.GE});
            this.dataGridView1.Location = new System.Drawing.Point(12, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(942, 224);
            this.dataGridView1.TabIndex = 28;
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
            this.dateTimePicker1.Location = new System.Drawing.Point(884, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 40);
            this.button1.TabIndex = 26;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 20);
            this.textBox1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "BUSQUEDA DE USUARIOS POR: NOMBRE | CARNET | CELULAR | EDAD";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Venta_de_Coches.Properties.Resources.motors;
            this.pictureBox1.Location = new System.Drawing.Point(724, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Buscar_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_sal);
            this.Controls.Add(this.btn_vol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Buscar_users";
            this.Text = "Busqueda de Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_sal;
        private System.Windows.Forms.Button btn_vol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn AP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CA;
        private System.Windows.Forms.DataGridViewTextBoxColumn RO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ED;
        private System.Windows.Forms.DataGridViewTextBoxColumn GE;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}