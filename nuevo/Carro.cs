using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuevo
{
    class Carro:Transporte
    {
        public string animal;
        public Persona unaPersona;

        public override bool tieneMotor
        {
            get { return false; }
        }
    }
}
