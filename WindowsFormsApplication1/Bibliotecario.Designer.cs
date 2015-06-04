namespace WindowsFormsApplication1
{
    partial class Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnguardarlector = new System.Windows.Forms.Button();
            this.btncancelarlect = new System.Windows.Forms.Button();
            this.txtintlec = new System.Windows.Forms.TextBox();
            this.txttellec = new System.Windows.Forms.TextBox();
            this.txtdirlec = new System.Windows.Forms.TextBox();
            this.txtnomlec = new System.Windows.Forms.TextBox();
            this.txtapelec = new System.Windows.Forms.TextBox();
            this.txtcedlec = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sancion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnguardarlector);
            this.panel2.Controls.Add(this.btncancelarlect);
            this.panel2.Controls.Add(this.txtintlec);
            this.panel2.Controls.Add(this.txttellec);
            this.panel2.Controls.Add(this.txtdirlec);
            this.panel2.Controls.Add(this.txtnomlec);
            this.panel2.Controls.Add(this.txtapelec);
            this.panel2.Controls.Add(this.txtcedlec);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(13, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(648, 176);
            this.panel2.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Snow;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Institucion :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Snow;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Telefono :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Snow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Direccion :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Snow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nombres :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Snow;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Apellidos :";
            // 
            // btnguardarlector
            // 
            this.btnguardarlector.Location = new System.Drawing.Point(489, 73);
            this.btnguardarlector.Name = "btnguardarlector";
            this.btnguardarlector.Size = new System.Drawing.Size(75, 23);
            this.btnguardarlector.TabIndex = 13;
            this.btnguardarlector.Text = "Guardar";
            this.btnguardarlector.UseVisualStyleBackColor = true;
            // 
            // btncancelarlect
            // 
            this.btncancelarlect.Location = new System.Drawing.Point(489, 127);
            this.btncancelarlect.Name = "btncancelarlect";
            this.btncancelarlect.Size = new System.Drawing.Size(75, 23);
            this.btncancelarlect.TabIndex = 12;
            this.btncancelarlect.Text = "Cancelar";
            this.btncancelarlect.UseVisualStyleBackColor = true;
            // 
            // txtintlec
            // 
            this.txtintlec.Location = new System.Drawing.Point(85, 150);
            this.txtintlec.Name = "txtintlec";
            this.txtintlec.Size = new System.Drawing.Size(291, 20);
            this.txtintlec.TabIndex = 11;
            // 
            // txttellec
            // 
            this.txttellec.Location = new System.Drawing.Point(86, 124);
            this.txttellec.Name = "txttellec";
            this.txttellec.Size = new System.Drawing.Size(160, 20);
            this.txttellec.TabIndex = 9;
            // 
            // txtdirlec
            // 
            this.txtdirlec.Location = new System.Drawing.Point(86, 97);
            this.txtdirlec.Name = "txtdirlec";
            this.txtdirlec.Size = new System.Drawing.Size(291, 20);
            this.txtdirlec.TabIndex = 7;
            // 
            // txtnomlec
            // 
            this.txtnomlec.Location = new System.Drawing.Point(86, 71);
            this.txtnomlec.Name = "txtnomlec";
            this.txtnomlec.Size = new System.Drawing.Size(291, 20);
            this.txtnomlec.TabIndex = 6;
            // 
            // txtapelec
            // 
            this.txtapelec.Location = new System.Drawing.Point(85, 43);
            this.txtapelec.Name = "txtapelec";
            this.txtapelec.Size = new System.Drawing.Size(291, 20);
            this.txtapelec.TabIndex = 5;
            // 
            // txtcedlec
            // 
            this.txtcedlec.Location = new System.Drawing.Point(87, 11);
            this.txtcedlec.Name = "txtcedlec";
            this.txtcedlec.Size = new System.Drawing.Size(160, 20);
            this.txtcedlec.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Snow;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cedula :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_modificar);
            this.panel1.Controls.Add(this.btn_nuevo);
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Location = new System.Drawing.Point(13, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 45);
            this.panel1.TabIndex = 21;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(110, 13);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 3;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(20, 13);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_nuevo.TabIndex = 2;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(213, 13);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(80, 23);
            this.btn_salir.TabIndex = 9;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cedula,
            this.Apellidos,
            this.Nombres,
            this.Direccion,
            this.Telefono,
            this.Sancion});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(649, 143);
            this.dataGridView1.TabIndex = 29;
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cedula ";
            this.Cedula.Name = "Cedula";
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Sancion
            // 
            this.Sancion.HeaderText = "Sancion";
            this.Sancion.Name = "Sancion";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(378, 198);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 20);
            this.textBox4.TabIndex = 45;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "CI",
            "Apellidos"});
            this.comboBox2.Location = new System.Drawing.Point(379, 173);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(83, 21);
            this.comboBox2.TabIndex = 44;
            this.comboBox2.Text = "CI";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(469, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 23);
            this.button1.TabIndex = 46;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(671, 426);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Usuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnguardarlector;
        private System.Windows.Forms.Button btncancelarlect;
        private System.Windows.Forms.TextBox txtintlec;
        private System.Windows.Forms.TextBox txttellec;
        private System.Windows.Forms.TextBox txtdirlec;
        private System.Windows.Forms.TextBox txtnomlec;
        private System.Windows.Forms.TextBox txtapelec;
        private System.Windows.Forms.TextBox txtcedlec;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sancion;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;

    }
}