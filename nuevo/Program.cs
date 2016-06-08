using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuevo
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            //DateTime fecha;
            //fecha = DateTime.Now;
            //DateTime vence;
            //vence = DateTime.Parse("20/03/2017");
            //int valor;
            //valor = vence.CompareTo(fecha);
            
            //Console.WriteLine(fecha);
            //Console.WriteLine(vence);
            //Console.WriteLine(valor);
            //Console.ReadKey();

            Profesional p1 = new Profesional("230", "08/06/2016", "Pedro", "Valdes", 32000);
            p1.Mostrar();
            Console.ReadKey();



        }
    }
}
