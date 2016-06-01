using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploArchivosOK
{
    public class Profesor:Persona
    {
        public int legajo;
        public string materia;

        public Profesor()
        { }

        public Profesor(int legajo, string materia)
           
        {
            this.legajo = legajo;
            this.materia = materia;
        }

    }
}
