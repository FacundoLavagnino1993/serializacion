using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace EjemploArchivosOK
{
 [XmlInclude(typeof (Profesor))]
 [XmlInclude(typeof (Alumno))]
 [XmlInclude(typeof (vehiculos))]


    public class Aula
    {
        public string nombre;
        public Persona personita;
        public List<Persona> Lista;
       // public Profesor profeUno;
       // public Alumno alumUno;
        
        

        public Aula()
        { }


        public Aula(string Nombre, Persona persona)
        {
            this.nombre = Nombre;
            this.personita = persona;
            this.Lista = new List<Persona>();
        }

        

       

        

    }
}
