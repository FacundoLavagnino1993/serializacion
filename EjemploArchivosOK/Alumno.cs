using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploArchivosOK
{
     public class Alumno:Persona
    {

        public int legajo;
        public string materiaCursada;

        public Alumno()
        { }

        public Alumno(int leg, string materia)
        {
            this.legajo = leg;
            this.materiaCursada = materia;

        }

       





    }
}
