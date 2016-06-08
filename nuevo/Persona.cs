using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuevo
{
    public abstract class Persona
    {
        public string nombre;
        public string apellido;
        public int dni;

        public Persona()
        { }
        public Persona(string nom, string ape, int dni)
        {
            this.nombre = nom;
            this.apellido = ape;
            this.dni = dni;
        }
       

    }
}
