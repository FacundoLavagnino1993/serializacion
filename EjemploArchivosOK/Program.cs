using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace EjemploArchivosOK
{
    class Program
    {
        static void Main(string[] args)
        {
           Persona personaUno = new Persona("Pepe","Muleiro");
           Aula aulaUno = new Aula("Magna", personaUno);

           ManejadorDeArchivo.GuardarAula(aulaUno);

            ManejadorDeArchivo.GuardarPersona(personaUno);
            ManejadorDeArchivo.escribir();
            ManejadorDeArchivo.leer();
            Console.ReadLine();
        }
    }
}
