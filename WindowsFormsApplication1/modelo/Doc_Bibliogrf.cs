using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.modelo
{
    class Doc_Bibliogrf
    {
        private string id_doc;
        private string num_doc;
        private string tit_doc;
        private int anio_doc;
        private string est_doc;
        private int ejem_doc;
        private string det_doc;        
        private List<Doc_Bibliogrf> lista_Doc = new List<Doc_Bibliogrf>();

        private Libro libro;
        private Revista revista;
        private Tesis tesis;

        public string iddoc
        {
            get { return id_doc; }
            set { id_doc = value; }
        }
        public string numdoc
        {
            get { return num_doc; }
            set { num_doc = value; }
        }
        public string titdoc
        {
            get { return tit_doc; }
            set { tit_doc = value; }
        }
        public int aniodoc
        {
            get { return anio_doc; }
            set { anio_doc = value; }
        }
        public string estdoc
        {
            get { return est_doc; }
            set { est_doc = value; }
        }
        public int ejemdoc
        {
            get { return ejem_doc; }
            set { ejem_doc = value; }
        }
        public string detdoc
        {
            get { return det_doc; }
            set { det_doc = value; }
        }
        internal List<Doc_Bibliogrf> ListaDocumentos
        {
            get { return lista_Doc; }
            set { lista_Doc = value; }
        }
        public Libro Libro
        {
            get { return libro; }
            set { libro = value; }
        }
        public Revista Revista
        {
            get { return revista; }
            set { revista = value; }
        }
        public Tesis Tesis
        {
            get { return tesis; }
            set { tesis = value; }
        }
    }
}
