using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EjemploArchivosOK
{
    public class Aula
    {
        public string nombre;
        public Persona profesor;
        public List<Persona> ListaDeAlumnos;

        public Aula()
        { }
        public Aula(string Nombre, Persona persona)
        {
            this.nombre = Nombre;
            this.profesor = persona;
            this.ListaDeAlumnos = new List<Persona>();
        }

    }
}
