using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuevo
{
    class Camioneta:Transporte
    {
        public float altura;

        public override bool tieneMotor
        {
            get { return true; }
        }
    }
}
