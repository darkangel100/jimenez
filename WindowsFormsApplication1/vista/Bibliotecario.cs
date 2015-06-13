using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.controlador;

namespace WindowsFormsApplication1
{
    public partial class Usuario : Form
    {
        string estado = "";
        int indice;
        public Usuario()
        {
            InitializeComponent();
        }
        //metodo Adiciona, para el boton guardar, guarda los datos en la base de datos-
        private void Adiciona()
        {
            try
            {
                UsuarioDB objB = new UsuarioDB();
                int resp;
                llenaUsuario(objB);
                resp = objB.InsertaUsuario(objB.getUsuario());
                if (resp == 0)
                {
                    MessageBox.Show("No se ingresó datos del Usuario", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Usuario Ingresado", "Bilioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos," + ex.Message, "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //metodo llena Usuario--------------------------------------------------------------------------------
        private UsuarioDB llenaUsuario(UsuarioDB usua)
        {
            usua.getUsuario().cedusu = txtid.Text.Trim();
            usua.getUsuario().cedusu = txtapelec.Text.Trim();
            usua.getUsuario().apeusu = txtapelec.Text.Trim();
            usua.getUsuario().nomusu = txtnomlec.Text.Trim();
            usua.getUsuario().dirusu = txtdirlec.Text.Trim();
            usua.getUsuario().telusu = txttellec.Text.Trim();
            usua.getUsuario().insusu = txtintlec.Text.Trim();
            if (radioButton1.Checked == true)
            {
                usua.getUsuario().estusu = "A";
            }
            else
            {
                usua.getUsuario().estusu = "B";
            }
            return usua;
        }
        int fila;
        public void llenaUsuario(string est)
        {
            try
            {
                dataGridView1.Rows.Clear();
                UsuarioDB objC = new UsuarioDB();
                objC.getUsuario().Listausuario = objC.TraeUsuarios(est);
                if (objC.getUsuario().Listausuario.Count == 0)
                {
                    MessageBox.Show("No existen Usuario Registrados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    fila = 0;
                    for (int i = 0; i < objC.getUsuario().Listausuario.Count; i++)
                    {
                        dataGridView1.Rows.Add(1);
                        dataGridView1.Rows[i].Cells[0].Value = objC.getUsuario().Listausuario[i].cedusu;
                        dataGridView1.Rows[i].Cells[1].Value = objC.getUsuario().Listausuario[i].apeusu;
                        dataGridView1.Rows[i].Cells[2].Value = objC.getUsuario().Listausuario[i].Nombre;
                        dataGridView1.Rows[i].Cells[3].Value = objC.getUsuario().Listausuario[i].dirusu;
                        dataGridView1.Rows[i].Cells[4].Value = objC.getUsuario().Listausuario[i].telusu;
                        //dataGridView1.Rows[i].Cells[5].Value = objC.getUsuario().Listausuario[i].insusu;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Presentar los Datos, " + ex.Message, "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void modificar()
        {
            try
            {
                UsuarioDB objC = new UsuarioDB();
                objC.setUsuario(objC.TraeUsuario(dataGridView1.Rows[fila].Cells[0].Value.ToString()));
                if (objC.getUsuario().cedusu == "")
                {
                    MessageBox.Show("No existen registros  de Usuarios", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    txtcedlec.Text = objC.getUsuario().cedusu;
                    txtapelec.Text = objC.getUsuario().apeusu;
                    txtnomlec.Text = objC.getUsuario().nomusu;
                    txtdirlec.Text = objC.getUsuario().dirusu;
                    txttellec.Text = objC.getUsuario().telusu;
                    txtintlec.Text = objC.getUsuario().insusu;
                    if (objC.getUsuario().estusu == "A")
                    {
                        radioButton1.Checked = true;

                    }
                    else
                    {
                        radioButton1.Checked = true;
                        btn_modificar.Enabled = true;
                        estado = "E";
                        panel1.Enabled = true;
                        txtcedlec.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al presentar los datos," + ex.Message, "Biblioteca");
            }
        }
        private void eliminar()
        {
            try
            {
                UsuarioDB objB = new UsuarioDB();
                int resp;
                string ced = dataGridView1.Rows[fila].Cells[0].Value.ToString();
                if (MessageBox.Show("Desea eliminar a: " + dataGridView1.Rows[fila].Cells[0].Value.ToString(), "Biblioteca", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    resp = objB.EliminaUsuario(ced);
                    if (resp > 0)
                    {
                        MessageBox.Show("Usuario Eliminado", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        llenaUsuario("A");
                    }
                    else
                    {
                        MessageBox.Show("No se ha eliminado el Usuario", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show(ex.Message, "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Eliminar Datos, " + ex.Message, "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Editar()
        {
            try
            {
                UsuarioDB objB = new UsuarioDB();
                int resp;
                objB.getUsuario().cedusu = txtcedlec.Text;
                llenaUsuario(objB);
                resp = objB.ActualizaUsuario(objB.getUsuario());
                if (resp == 0)
                {
                    MessageBox.Show("No se Modifico datos del Usuario", "biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Usuario Modificado", "biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    estado = "";
                    llenaUsuario("A");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar datos," + ex.Message, "biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }
        private void nuevo()
        {

            try
            {
                estado = "N";
                panel2.Enabled = true;
                Util.limpiar(panel2.Controls);
                txtcedlec.Enabled = true;
                codigo();
                txtid.Enabled = false;
                txtcedlec.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error," + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnguardarlector_Click(object sender, EventArgs e)
        {
            if (estado == "N")
            {
                Adiciona();
            }
            if (estado == "E")
            {
                Editar();
            }
            Util.limpiar(panel2.Controls);
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            llenaUsuario("A");
            panel2.Enabled = false;
        }
        private void codigo()
        {
            try
            {
                int nro;
                string cod = txtid.Text.ToString();
                UsuarioDB objp = new UsuarioDB();
                nro = objp.traeCodigo();
                txtid.Text = Util.codi(cod, nro);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar los datos," + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            llenaUsuario("A");
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            modificar();
            panel2.Enabled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = dataGridView1.CurrentRow.Index;
        }
    }
}
