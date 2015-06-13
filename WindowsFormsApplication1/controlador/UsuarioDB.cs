using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using WindowsFormsApplication1.modelo;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication1.controlador
{
    class UsuarioDB
    {
        conexion con = new conexion();
        Usuario1 usu = null;

        public Usuario1 getUsuario()
        {
            if (this.usu == null)
            {
                this.usu = new Usuario1();
                Usuario1 persona = new Usuario1();
            }
            return this.usu;
        }
        public void setUsuario(Usuario1 usuarios)
        {
            this.usu = usuarios;
        }
        public void limpiar()
        {
            this.usu = null;
        }
        
        public int InsertaUsuario(Usuario1 usu)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {
                string sqlcad = "Insert usuario Values('"+usu.codusu+"','" + usu.cedusu + "','" + usu.apeusu + "','" + usu.nomusu + "','" + usu.dirusu + "','" + usu.telusu + "','" + usu.insusu + "','" + usu.estusu + "')";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                resp = cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                resp = 0;
                throw ex;
            }
            catch (Exception ex)
            {
                resp = 0;
                throw ex;
            }
            cn.Close();
            cmd = null;
            usu = null;
            return resp;
        }
        public List<Usuario1> TraeUsuarios (string est)
        {
            UsuarioDB usu = null;
            List<Usuario1> ListaUsu = new List<Usuario1>();
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();

            try
            {
                string sqlcad = "Select * from usuario where estado='" + est + "' order by apellido";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    usu = new UsuarioDB();
                    usu.getUsuario().cedusu = dr[0].ToString();
                    usu.getUsuario().apeusu = dr[1].ToString();
                    usu.getUsuario().nomusu = dr[2].ToString();
                    usu.getUsuario().dirusu = dr[3].ToString();
                    usu.getUsuario().telusu = dr[4].ToString();
                    usu.getUsuario().insusu = dr[5].ToString();
                    usu.getUsuario().estusu = dr[6].ToString();

                    usu.getUsuario().Nombre = usu.getUsuario().apeusu + " " + usu.getUsuario().nomusu;
                    ListaUsu.Add(usu.getUsuario());
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                usu = null;
                throw ex;
            }
            catch (Exception ex)
            {
                usu = null;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return ListaUsu;
        }
        public Usuario1 TraeUsuario(string ced)
        {
            UsuarioDB usu = null;
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlcad = "Select * from usuario where cedula='" + ced + "'";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    usu = new UsuarioDB();
                    //usu.getUsuario().codusu = dr[0].ToString();
                    usu.getUsuario().cedusu = dr[0].ToString();
                    usu.getUsuario().apeusu = dr[1].ToString();
                    usu.getUsuario().nomusu = dr[2].ToString();
                    usu.getUsuario().dirusu = dr[3].ToString();
                    usu.getUsuario().telusu = dr[4].ToString();
                    usu.getUsuario().insusu = dr[5].ToString();
                    usu.getUsuario().estusu = dr[6].ToString();
                    
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                usu = null;
                throw ex;
            }
            catch (Exception ex)
            {
                usu = null;
                throw ex;
            }
            cn.Close();
            cmd = null;

            return usu.getUsuario();
        }
        public int EliminaUsuario(string ced)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp = 0;
            try
            {
                string sqlcad = "Update usuario set estado='P' WHERE cedula='" + ced + "'";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                resp = cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                resp = 0;
                throw ex;
            }
            catch (Exception ex)
            {
                resp = 0;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return resp;
        }
        public int ActualizaUsuario(Usuario1 usu)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {
                string sqlcad = "Update usuario set apellido='" + usu.apeusu + "',nommbre='" + usu.nomusu + "',direccion='" + usu.dirusu + "',telefono='" + usu.telusu + "',institucion='" + usu.insusu + "',estado='" + usu.estusu + "' WHERE cedeula='" + usu.cedusu + "'";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                resp = cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                resp = 0;
                throw ex;
            }
            catch (Exception ex)
            {
                resp = 0;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return resp;
        }
        public int traeCodigo()
        {
            int nro = 0;
            MySqlConnection cn = con.GetConnection();
            MySqlCommand cmd;
            try
            {
                string sqlcad = "Select max(SUBSTRING(id_persona,3))as nro from usuario";
                cmd = new MySqlCommand(sqlcad, cn);
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (DBNull.Value == dr["nro"])
                        nro = 0;
                    else
                        nro = Convert.ToInt32(dr["nro"]);

                }
                dr.Close();


            }
            catch (MySqlException ex)
            {
                nro = 0;
                throw ex;
            }
            catch (Exception ex)
            {
                nro = 0;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return nro;
        }

    }
}
