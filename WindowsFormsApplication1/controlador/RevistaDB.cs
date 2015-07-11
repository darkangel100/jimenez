using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using WindowsFormsApplication1.modelo;

namespace WindowsFormsApplication1.controlador
{
    class RevistaDB
    {
        conexion con = new conexion();
        Doc_Bibliogrf docum = null;

        public Doc_Bibliogrf getrevista()
        {
            if (this.docum == null)
            {
                this.docum = new Doc_Bibliogrf();
                Revista revistas = new Revista();
                //this.docum.Revista = revistas;
            }
            return this.docum;
        }
    }
}
