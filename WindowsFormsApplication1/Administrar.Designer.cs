namespace WindowsFormsApplication1
{
    partial class Administrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrar));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.libroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.revistaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tesisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem1,
            this.libroToolStripMenuItem1,
            this.revistaToolStripMenuItem1,
            this.tesisToolStripMenuItem1,
            this.prestamoToolStripMenuItem1,
            this.deToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(446, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem1
            // 
            this.usuarioToolStripMenuItem1.Name = "usuarioToolStripMenuItem1";
            this.usuarioToolStripMenuItem1.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem1.Text = "Usuario";
            this.usuarioToolStripMenuItem1.Click += new System.EventHandler(this.usuarioToolStripMenuItem1_Click);
            // 
            // libroToolStripMenuItem1
            // 
            this.libroToolStripMenuItem1.Name = "libroToolStripMenuItem1";
            this.libroToolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
            this.libroToolStripMenuItem1.Text = "Libro";
            this.libroToolStripMenuItem1.Click += new System.EventHandler(this.libroToolStripMenuItem1_Click);
            // 
            // revistaToolStripMenuItem1
            // 
            this.revistaToolStripMenuItem1.Name = "revistaToolStripMenuItem1";
            this.revistaToolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.revistaToolStripMenuItem1.Text = "Revista";
            this.revistaToolStripMenuItem1.Click += new System.EventHandler(this.revistaToolStripMenuItem1_Click);
            // 
            // tesisToolStripMenuItem1
            // 
            this.tesisToolStripMenuItem1.Name = "tesisToolStripMenuItem1";
            this.tesisToolStripMenuItem1.Size = new System.Drawing.Size(45, 20);
            this.tesisToolStripMenuItem1.Text = "Tesis";
            this.tesisToolStripMenuItem1.Click += new System.EventHandler(this.tesisToolStripMenuItem1_Click);
            // 
            // prestamoToolStripMenuItem1
            // 
            this.prestamoToolStripMenuItem1.Name = "prestamoToolStripMenuItem1";
            this.prestamoToolStripMenuItem1.Size = new System.Drawing.Size(69, 20);
            this.prestamoToolStripMenuItem1.Text = "Prestamo";
            this.prestamoToolStripMenuItem1.Click += new System.EventHandler(this.prestamoToolStripMenuItem1_Click);
            // 
            // deToolStripMenuItem
            // 
            this.deToolStripMenuItem.Name = "deToolStripMenuItem";
            this.deToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.deToolStripMenuItem.Text = "Devolucion";
            this.deToolStripMenuItem.Click += new System.EventHandler(this.deToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuItem1.Text = "Reportes";
            // 
            // Administrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(446, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Administrar";
            this.Text = "Munu principal ";
            this.Load += new System.EventHandler(this.Administrar_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem libroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem revistaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tesisToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prestamoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}