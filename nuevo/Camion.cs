using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuevo
{
    public class Camion:Transporte
    {
        public int cantRuedas;
        public Profesional chofer;
        public override bool tieneMotor
        {
            get { return true; }
        }

        public Camion()
        { }

        public Camion(int cantiRuedas, Profesional conductor, int Capa)
            : base(Capa)
        {
            this.cantRuedas = cantiRuedas;
            this.chofer = conductor;
        }

    }
}
