using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Administrar : Form
    {
        public Administrar()
        {
            InitializeComponent();
        }
       
        
        private void Administrar_Load(object sender, EventArgs e)
        {
            
        }
        
        Usuario Usuario = new Usuario();
        Libro libro = new Libro();
        Revista Revista = new Revista();
        Tesis Tesis = new Tesis();
        Prestamos prestamos = new Prestamos();
        Devoluciones Devolucion = new Devoluciones();
        Administrador Admistrador = new Administrador();
        Reportes reportes = new Reportes();

       
        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Usuario.ShowDialog();
        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            libro.ShowDialog();
        }

     
        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Usuario.ShowDialog();
        }

        private void libroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            libro.ShowDialog();
        }

        private void revistaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Revista.ShowDialog();
        }

        private void tesisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tesis.ShowDialog();
        }

        private void prestamoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            prestamos.ShowDialog();
        }

        private void deToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Devolucion.ShowDialog();
        }

        private void Reportes_Click(object sender, EventArgs e)
        {
            reportes.ShowDialog();
        }

        private void MnAdministrador_Click(object sender, EventArgs e)
        {
            Admistrador.ShowDialog();
           
        }
    }
}
