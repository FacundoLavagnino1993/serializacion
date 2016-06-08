using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuevo
{
    public class Conductor:Persona
    {
        public Conductor()//Constructor por defecto.
        { }
        public Conductor(string nombre, string apellido, int dni)//Constructor que recibe los parametros, nombre, apellido, dni y se los pasa al constructor de la clase base.
            : base(nombre, apellido, dni) 
        {
 
        }
            

       
    }
}
