using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace EjemploArchivos
{
    

   public class Estacionamiento:Iserializable
    {
       public Persona elDueño;
       public List<Vehiculo> listaDeVehiculos;

       public Estacionamiento()
       {
           this.listaDeVehiculos = new List<Vehiculo>();
       }





       public bool guardarEnXml()
       {
           return ManejadorXml.GuardarEstacionamiento(this);
       }
    }
}
