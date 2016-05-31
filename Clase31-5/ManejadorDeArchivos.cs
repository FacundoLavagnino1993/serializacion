using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Clase31_5
{
    class ManejadorDeArchivos
    {
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
