using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuevo
{
    public class GeneradoraDeDatos
    {



        public static List<Cajon> listaCajones(int CantidadDeCajones)
        {
            List<Cajon> Lista = new List<Cajon>(CantidadDeCajones);


            for (int i = 0; i < CantidadDeCajones; i++)
            {
                Random rmd = new Random();

                if ((rmd.Next(0, 1) == 0))
                {
                    Lista.Add(new CajonFruta());   /// 
                }
                else
                {
                    Lista.Add(new CajonVerdura());
                }
            }

            return Lista;
        }
    }
}
