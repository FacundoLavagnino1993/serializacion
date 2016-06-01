using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EjemploArchivosOK
{
    

    public class Persona:serHumano
    {
        public string nombre;
        public string apellido;
        
        public Persona()
        { }


        public Persona(string Nombre, string Apellido, string dni):base(dni)
        {
            this.nombre = Nombre;
            this.apellido = Apellido;
        }

        
    }
}
