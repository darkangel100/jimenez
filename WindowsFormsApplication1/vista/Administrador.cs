using System;
using WindowsFormsApplication1.controlador;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Administrador : Form
    {
        string estado = "";
        public Administrador()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void adiciona()
        {
            try
            {
                BibliotecarioDB objB = new BibliotecarioDB();
                int resp;
                llenabibliotecario(objB);
                resp = objB.InsertaBibliotecario(objB.getBibliotecario());
                if (resp == 0)
                {
                    MessageBox.Show("No se ingresó datos del Usuario", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Usuario Ingresado", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos," + ex.Message, "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private BibliotecarioDB llenabibliotecario(BibliotecarioDB bib)
        {
            bib.getBibliotecario().cedbi = txtcedlec.Text.Trim();
            bib.getBibliotecario().apebi = txtapelec.Text.Trim();
            bib.getBibliotecario().nombi = txtnomlec.Text.Trim();
            bib.getBibliotecario().dirbi = txtdirlec.Text.Trim();
            bib.getBibliotecario().telbi = txttellec.Text.Trim();
            bib.getBibliotecario().Persona.clabi = txtconClav.Text.Trim();
            if (rbnactivo.Checked == true)
            {
                bib.getBibliotecario().estbi = "A";
            }
            else
            {
                bib.getBibliotecario().estbi = "P";
            }
            return bib;
        }
        int fila = -1;
        public void llenaBibliotecarios(string est)
        {
            try
            {
                dgvbibl.Rows.Clear();
                BibliotecarioDB objB = new BibliotecarioDB();
                objB.getBibliotecario().Listabibliotecarios = objB.TraeBibliotecarios(est);
                if (objB.getBibliotecario().Listabibliotecarios.Count == 0)
                {
                    MessageBox.Show("No existen Usuarios Registrados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    fila = 0;
                    for (int i = 0; i < objB.getBibliotecario().Listabibliotecarios.Count; i++)
                    {
                        dgvbibl.Rows.Add(1);
                        dgvbibl.Rows[i].Cells[0].Value = objB.getBibliotecario().Listabibliotecarios[i].cedbi;
                        dgvbibl.Rows[i].Cells[1].Value = objB.getBibliotecario().Listabibliotecarios[i].apebi;
                        dgvbibl.Rows[i].Cells[2].Value = objB.getBibliotecario().Listabibliotecarios[i].nombi;
                        dgvbibl.Rows[i].Cells[3].Value = objB.getBibliotecario().Listabibliotecarios[i].telbi;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Presentar los Datos, " + ex.Message, "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnguardarlector_Click(object sender, EventArgs e)
        {
            if (estado == "N")
            {
                adiciona();
            }
            if (estado == "E")
            {
                //Editar();
            }
            Util.limpiar(panel2.Controls);
            rbnactivo.Checked = false;
            rbnbaja.Checked = false;
            llenaBibliotecarios("A");
            panel2.Enabled = false;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            estado = "N";
            panel2.Enabled = true;
            Util.limpiar(panel2.Controls);
            txtcedlec.Enabled = true;
            txtcedlec.Focus();
        }
    }
}
