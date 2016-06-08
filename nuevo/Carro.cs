using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuevo
{
    public class Carro:Transporte
    {
        public string animal;
        public Persona unaPersona;

        public override bool tieneMotor
        {
            get { return false; }
        }

        public Carro()
        { }

        public Carro(string Animal, Persona persona, int capacidad)
            : base(capacidad)
        {
            this.animal = Animal;
            this.unaPersona = persona;
        }
    }
}
