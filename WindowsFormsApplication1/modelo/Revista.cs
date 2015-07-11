using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.modelo
{
    class Revista:Doc_Bibliogrf
    {
        private string id_rev;
        private string num_rev;
        private string isn_rev;
        private string edic_rev;

        public string idrev
        {
            get { return id_rev; }
            set { id_rev = value; }
        }
        public string numrev
        {
            get { return num_rev; }
            set { num_rev = value; }
        }
        public string isnrev
        {
            get { return isn_rev; }
            set { isn_rev = value; }
        }
        public string edicrev
        {
            get { return edic_rev; }
            set { edic_rev = value; }
        }
    }
}
