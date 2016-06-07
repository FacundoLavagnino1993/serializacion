using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuevo
{
    class Carro
    {
        public string animal;
        public string persona;

        public override bool tieneMotor
        {
            get { return false; }
        }
    }
}
