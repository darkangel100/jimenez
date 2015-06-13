using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.modelo
{
    class Usuario1
    {
        private string cod_usu;
        private string ced_usu;
        private string ape_usu;
        private string nom_usu;
        private string dir_usu;
        private string tel_usu;
        private string ins_usu;
        private string est_usu;
        private List<Usuario1> listaUsuarios = new List<Usuario1>();
        private string nombre;

        public string codusu
        {
            get { return cod_usu; }
            set { cod_usu = value; }
        }

        public string cedusu
        {
            get { return ced_usu; }
            set { ced_usu = value; }
        }
        public string apeusu
        {
            get { return ape_usu; }
            set { ape_usu = value; }
        }
        public string nomusu
        {
            get { return nom_usu; }
            set { nom_usu = value; }
        }
        public string dirusu
        {
            get { return dir_usu; }
            set { dir_usu = value; }
        }
        public string telusu
        {
            get { return tel_usu; }
            set { tel_usu = value; }
        }
        public string insusu
        {
            get { return ins_usu; }
            set { ins_usu = value; }
        }
        public string estusu
        {
            get { return est_usu; }
            set { est_usu = value; }
        }
        public List<Usuario1> Listausuario
        {
            get { return listaUsuarios; }
            set { listaUsuarios = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
