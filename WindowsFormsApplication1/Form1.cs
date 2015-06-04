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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        string Bibliotecario="Alvaro", administrador="Stalin";
        string ClaveBiblio = "A123", CalveAdmis = "S123";
        private void button1_Click(object sender, EventArgs e)
        {
            Administrar Administrar = new Administrar();
            Administrador Administrador = new Administrador();

            if (txtNombre1.Text == Bibliotecario && txtClave.Text == ClaveBiblio || txtNombre1.Text == administrador && txtClave.Text == CalveAdmis)
            {
                if (txtNombre1.Text == Bibliotecario)
                {
                  // Administrar.Show();
                    this.Hide();
                    Administrar.ShowDialog();
                    this.Show();
                    
                }
                else
                {
                    this.Hide();
                    Administrador.ShowDialog();
                    this.Show();

                }

            }
            else
            {
                MessageBox.Show("El nombre o clave son incorrectos" + MessageBoxIcon.Error);
            }
           
           
            
        }

       
    }
}
