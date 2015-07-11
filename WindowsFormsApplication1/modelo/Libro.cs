using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.modelo
{
    class Libro:Doc_Bibliogrf
    {
        private string id_lib;
        private string num_lib;
        private string isb_lib;
        private string edi_lib;

        public string idlib
        {
            get { return id_lib; }
            set { id_lib = value; }
        }
        public string numlib
        {
            get { return num_lib; }
            set { num_lib = value; }
        }
        public string isbnlib
        {
            get { return isb_lib; }
            set { isb_lib = value; }
        }
        public string editlib
        {
            get { return edi_lib; }
            set { edi_lib = value; }
        }
    }
}
