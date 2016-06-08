using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuevo
{
    class Camion:Transporte
    {
        public int cantRuedas;
        public Profesional chofer;
        public override bool tieneMotor
        {
            get { return true; }
        }
    }
}
