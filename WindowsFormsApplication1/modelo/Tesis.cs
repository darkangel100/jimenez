using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.modelo
{
    class Tesis:Doc_Bibliogrf
    {
        private string id_tes;
        private string num_tes;
        private string car_tes;

        public string idtes
        {
            get { return id_tes; }
            set { id_tes = value; }
        }
        public string numtes
        {
            get { return num_tes; }
            set { num_tes = value; }
        }
        public string cartes
        {
            get { return car_tes; }
            set { car_tes = value; }
        }
    }
}
