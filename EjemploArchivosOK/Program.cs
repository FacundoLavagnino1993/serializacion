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
           Persona personaDos = new Persona("Juanito", "Arcoiris");
           Persona personaTres = new Persona("Pechugas", "Laru");
           Persona personaCuatro = new Persona("Lucy", "Loles");

           Aula aulaUno = new Aula("Magna", personaUno);
           List<Persona> listaNueva = new List<Persona>();
           listaNueva.Add(personaUno);
           listaNueva.Add(personaDos);
          // listaNueva.Add(personaTres);
           // listaNueva.Add(personaCuatro);

           aulaUno.ListaDeAlumnos.Add(personaTres);
           aulaUno.ListaDeAlumnos.Add(personaCuatro);

            ManejadorDeArchivo.GuardarAula(aulaUno);

            ManejadorDeArchivo.GuardarPersona(personaUno);
            ManejadorDeArchivo.GuardarLista(listaNueva);
            ManejadorDeArchivo.escribir();
            ManejadorDeArchivo.leer();
            Console.ReadLine();
        }
    }
}
