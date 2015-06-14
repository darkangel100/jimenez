using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.modelo
{
    class Persona:Bibliotecario
    {
        private string cla_bi;
        private string tip_bi;

        public string clabi
        {
            get { return cla_bi; }
            set { cla_bi = value; }
        }
        public string tipusu
        {
            get { return tip_bi; }
            set { tip_bi = value; }
        }
    }
}
