using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Clase31_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona personaUno = new Persona();
            try
            { 
                using(XmlWriter xml = new XmlWriter()
                {
                  
                }
            }
            ManejadorDeArchivos.escribir();
            ManejadorDeArchivos.leer();
            Console.ReadLine();
        }
    }
}
