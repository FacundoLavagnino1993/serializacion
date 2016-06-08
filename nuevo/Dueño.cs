using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuevo
{
    public class Dueño:Persona
    {
        public string cuit;

        public Dueño()
        { }

        public Dueño(string Cuit, string nom, string ape, int dni)
            : base(nom, ape, dni)
        {
            this.cuit = Cuit;
        }
    }
}
