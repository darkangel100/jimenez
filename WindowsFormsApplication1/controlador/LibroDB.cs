using System;
using MySql.Data;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using WindowsFormsApplication1.modelo;

namespace WindowsFormsApplication1.controlador
{
    class LibroDB
    {
        conexion con = new conexion();
        Doc_Bibliogrf doc = null;

        public Doc_Bibliogrf getDocumento()
        {
            if (this.doc == null)
            {
                this.doc = new Doc_Bibliogrf();
                Libro libros = new Libro();
                //this.doc.Libro = libros;
            }
            return this.doc;
        }
        public void setDocumento(Doc_Bibliogrf docs)
        {
            this.doc = docs;
        }
        public void limpiar()
        {
            this.doc = null;
        }
    }
}
