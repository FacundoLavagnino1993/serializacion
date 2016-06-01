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
    public class ManejadorDeArchivo
    {
        public static bool GuardarAula(Aula aulaUno)
        {
            try
            {// el using es formato permanente, dentro del try
                using(XmlTextWriter escritura = new XmlTextWriter("Aula.Xml", Encoding.UTF8))
                {
                    XmlSerializer Serializar = new XmlSerializer(typeof(Aula));
                    Serializar.Serialize(escritura, aulaUno);
                    return true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool GuardarLista(List<Persona> lista)
        {
            try 
            {
                using(XmlTextWriter escritura = new XmlTextWriter("Lista.Xml", Encoding.UTF8))
                {
                    XmlSerializer serializar = new XmlSerializer(typeof(List<Persona>));
                    {
                        serializar.Serialize(escritura, lista);
                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static bool GuardarPersona(Persona unaPersona)
        {
            try
            {
                using (XmlTextWriter escribir = new XmlTextWriter("Persona.Xml", Encoding.UTF8))
                {
                    XmlSerializer Serializador = new XmlSerializer(typeof(Persona)); // el serializador pasara el tipo de dato persona a xml
                    Serializador.Serialize(escribir, unaPersona);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;

            }
        }
        
            public static void leer()
            {
                try
                {
                    string datos;
                    StreamReader lector = new StreamReader("Archivo/Ejemplo.txt");
                    datos = lector.ReadToEnd();
                    Console.WriteLine(datos);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            public static void escribir()
            {

                try
                {
                    StreamWriter escritor = new StreamWriter("Archivo/Ejemplo.txt", false);
                    // agregando, el bool al constructor "true" repite, false no.
                    escritor.WriteLine("Hola Mundo");
                    escritor.Write("C#");
                    escritor.WriteLine("\nEscritura en archivo");
                    escritor.Close();
                }


                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            public static void escribir2()
            {
                //Tanto lectura como escritura se usa try y catch
                using (StreamWriter escritor = new StreamWriter("Archivos/Ejemplo.txt"))
                {
                    try
                    {

                        // agregando, el bool al constructor "true" repite, false no.
                        escritor.WriteLine("Hola Mundo");
                        escritor.Write("C#");
                        escritor.WriteLine("\nEscritura en archivo");
                        escritor.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }

            }
        

    }
}
