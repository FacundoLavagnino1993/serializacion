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

            //Profesional p1 = new Profesional("230", "08/06/2016", "Pedro", "Valdes", 32000);
            //p1.Mostrar();

            CajonVerdura CV = new CajonVerdura();
            CajonVerdura CV2 = new CajonVerdura();
            CajonFruta CF = new CajonFruta();
            CajonFruta CF2 = new CajonFruta();

            CV.tipo = "Ortalizas";
            CV2.tipo = "Legumbres";
            CF.tipo = "Frutas de Estacion";
            CF2.tipo = "Frutas Exoticas";

            List<Transporte> listaDeTransporte = new List<Transporte>();


            List<Cajon> listaDeCajon = new List<Cajon>();
            listaDeCajon.Add(CV);
            listaDeCajon.Add(CF2);
            listaDeCajon.Add(CF);
            listaDeCajon.Add(CV2);

            foreach (Cajon item in listaDeCajon)
            {
                item.guardarEnXml();
            }

            Dueño dueño = new Dueño("30-44546666-8", "Juan", "Perez", 37444511);
            Profesional profesionalUno = new Profesional("123", "12/12/2016", "Pedro", "Gomez", 25444666);
            Profesional profesionalDos = new Profesional("234", "10/11/2016", "Julian", "Garcia", 24844322);
            Informal informal = new Informal("Pepe", "Pablo", "Gonzalez", 3448755);


            Camioneta camionetaUno = new Camioneta(4, profesionalUno, 1000);
            Camion camionUno = new Camion(8, profesionalDos, 20000);
            Carro carroUno = new Carro("Caballo", informal, 150);



            //Distribuidor distri = new Distribuidor(dueño,lista
            
            

            

            
           



            Console.ReadKey();



        }
    }
}
