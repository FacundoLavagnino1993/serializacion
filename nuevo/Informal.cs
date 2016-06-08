using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuevo
{
    class Informal:Conductor
    {
        public string apodo;

        public Informal()
        { }

        public Informal(string apod, string nom, string apellido, int dni)
            :base(nom, apellido, dni)

        {
            this.apodo = apod;
        }
    }
}

