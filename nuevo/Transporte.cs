using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuevo
{
    public abstract class Transporte
    {
        public int capacidadCajones;
        public abstract bool tieneMotor
        {
            get;
        }

        public string ToString()
        { return ""; }

        public Transporte()
        { }

        public Transporte(int capacidad)
        {
            this.capacidadCajones = capacidad;
        }
        


    }
}
