using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuevo
{
    public class Camioneta:Transporte
    {
        public float altura;
        public Profesional chofer;
        public override bool tieneMotor
        {
            get { return true; }
        }

        public Camioneta()
        { }

        public Camioneta(float alt, Profesional conduc, int capa)
            : base(capa)
        {
            this.altura = alt;
            this.chofer = conduc;
        }
    }
}
