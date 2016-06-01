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
          /* Persona personaUno = new Persona("Pepe","Muleiro","37189221");
           Persona personaDos = new Persona("Juanito", "Arcoiris","37189221");
           Persona personaTres = new Persona("Pechugas", "Laru","37189221");
           Persona personaCuatro = new Persona("Lucy", "Loles","37189221");
         
           Profesor profeUno = new Profesor();
           profeUno.materia = "Laboratorio";
           profeUno.legajo = 6445;
           

           Alumno alumUno = new Alumno();
           alumUno.materiaCursada = "Laboratorio";
           alumUno.legajo = 1955;

           Alumno alumDos = new Alumno(2344,"LabII");
           

           Alumno alumtres = new Alumno(5111,"LabII");
          
           Aula aulaUno = new Aula("Magna", personaUno);
           List<Persona> listaNueva = new List<Persona>();
           listaNueva.Add(personaUno);
           listaNueva.Add(personaDos);
            
          // listaNueva.Add(personaTres);
           // listaNueva.Add(personaCuatro);

            aulaUno.Lista.Add(personaTres);
            aulaUno.Lista.Add(personaCuatro);
            aulaUno.Lista.Add(profeUno);
            aulaUno.Lista.Add(alumUno);
            aulaUno.Lista.Add(alumDos);
            aulaUno.Lista.Add(alumtres);
            ManejadorDeArchivo.GuardarAula(aulaUno);

            ManejadorDeArchivo.GuardarPersona(personaUno);
            ManejadorDeArchivo.GuardarLista(listaNueva);
            ManejadorDeArchivo.escribir();
            ManejadorDeArchivo.leer();
            

            Aula MiAula;

            MiAula = ManejadorDeArchivo.CargarAula();
            */
            
            
            

            Dueño unDueño = new Dueño();
            unDueño.nombre = "juan";
            unDueño.apellido = "Perez";
            unDueño.dni = "37111555";
            unDueño.fechaInscripcion = "19/02/2015";
            unDueño.cuit = "20-33345111-5";

            Auto unAuto = new Auto();
            moto unaMoto = new moto();
            camioneta unaCamioneta = new camioneta();

            unAuto.tipoMotor = "1.6";
            unAuto.puertas = 4;
            unaMoto.tipoMotor = "150cc";
            unaMoto.cilindrada = 150;
            unaCamioneta.tipoMotor = "3.5";
            unaCamioneta.altura = 2;

            Estacionamiento unEstacionamiento = new Estacionamiento();
            unEstacionamiento.eldueño = unDueño;
            unEstacionamiento.listaVehiculos.Add(unAuto);
            unEstacionamiento.listaVehiculos.Add(unaMoto);
            unEstacionamiento.listaVehiculos.Add(unaCamioneta);
            
            Console.ReadLine();
        }
    }
}
