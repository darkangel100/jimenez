using System;
using MySql.Data;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using WindowsFormsApplication1.modelo;

namespace WindowsFormsApplication1.controlador
{
    class BibliotecarioDB
    {
        conexion con = new conexion();
        Bibliotecario bibl = null;

        public Bibliotecario getBibliotecario()
        {
            if (this.bibl == null)
            {
                this.bibl = new Bibliotecario();
                Bibliotecario persona = new Bibliotecario();
            }
            return this.bibl;
        }
        public void setBibliotecario(Bibliotecario bibliotecarios)
        {
            this.bibl = bibliotecarios;
        }
        public void limpiar()
        {
            this.bibl = null;
        }
        public int InsertaBibliotecario(Bibliotecario bibl)
        {
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            int resp;
            try
            {
                string sqlcad = "Insert bibliotecario Values('" + bibl.cedbi + "','" + bibl.apebi + "','" + bibl.nombi + "','" + bibl.dirbi + "'," + bibl.telbi + ",'" + bibl.Persona.clabi + "','" + bibl.estbi + "')";
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
            bibl = null;
            return resp;
        }
        public List<Bibliotecario> TraeBibliotecarios(string est)
        {
            BibliotecarioDB bibl = null;
            List<Bibliotecario> ListaBibl = new List<Bibliotecario>();
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();

            try
            {
                string sqlcad = "Select * from bibliotecario where est_bi='" + est + "' order by ape_bi";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    bibl = new BibliotecarioDB();
                    bibl.getBibliotecario().cedbi = dr[0].ToString();
                    bibl.getBibliotecario().apebi = dr[1].ToString();
                    bibl.getBibliotecario().nombi = dr[2].ToString();
                    bibl.getBibliotecario().dirbi = dr[3].ToString();
                    bibl.getBibliotecario().telbi = dr[4].ToString();
                    bibl.getBibliotecario().Persona.clabi = dr[5].ToString();
                    bibl.getBibliotecario().estbi = dr[6].ToString();

                    bibl.getBibliotecario().Nombre = bibl.getBibliotecario().apebi + " " + bibl.getBibliotecario().nombi;
                    ListaBibl.Add(bibl.getBibliotecario());
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                bibl = null;
                throw ex;
            }
            catch (Exception ex)
            {
                bibl = null;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return ListaBibl;
        }

        public Bibliotecario TraeBibliotecario(string ced)
        {
            BibliotecarioDB bibl = null;
            MySqlCommand cmd;
            MySqlConnection cn = con.GetConnection();
            try
            {
                string sqlcad = "Select * from bibliotecario where ced_bi='" + ced + "'";
                cmd = new MySqlCommand(sqlcad, cn);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    bibl = new BibliotecarioDB();
                    bibl.getBibliotecario().cedbi = dr[0].ToString();
                    bibl.getBibliotecario().apebi = dr[1].ToString();
                    bibl.getBibliotecario().nombi = dr[2].ToString();
                    bibl.getBibliotecario().dirbi = dr[3].ToString();
                    bibl.getBibliotecario().telbi = dr[4].ToString();
                    bibl.getBibliotecario().Persona.clabi = dr[5].ToString();
                    bibl.getBibliotecario().estbi = dr[6].ToString();
                }
                dr.Close();
            }
            catch (MySqlException ex)
            {
                bibl = null;
                throw ex;
            }
            catch (Exception ex)
            {
                bibl = null;
                throw ex;
            }
            cn.Close();
            cmd = null;
            return bibl.getBibliotecario();
        }
    }
}
