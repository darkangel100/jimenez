using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.modelo
{
    class Bibliotecario
    {
        private string ced_bi;
        private string ape_bi;
        private string nom_bi;
        private string dir_bi;
        private string tel_bi;
        private string est_bi;
        private List<Bibliotecario> listaBibliotecarios = new List<Bibliotecario>();
        private string nombre;
        private Persona persona;

        public string cedbi
        {
            get { return ced_bi; }
            set { ced_bi = value; }
        }
        public string apebi
        {
            get { return ape_bi; }
            set { ape_bi = value; }
        }
        public string nombi
        {
            get { return nom_bi; }
            set { nom_bi = value; }
        }
        public string dirbi
        {
            get { return dir_bi; }
            set { dir_bi = value; }
        }
        public string telbi
        {
            get { return tel_bi; }
            set { tel_bi = value; }
        }
        public string estbi
        {
            get { return est_bi; }
            set { est_bi = value; }
        }
        public List<Bibliotecario> Listabibliotecarios
        {
            get { return listaBibliotecarios; }
            set { listaBibliotecarios = value; }
        }
        public Persona Persona
        {
            get { return persona; }
            set { persona = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
