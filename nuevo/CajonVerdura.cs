using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuevo
{
    public class CajonVerdura:Cajon
    {
        public string tipo;

        public CajonVerdura()
        {}


        public override void Mostrar()
        {
            Console.WriteLine("Tipo : " + this.tipo);
        }
    }
}
