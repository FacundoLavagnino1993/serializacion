using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nuevo
{
    public class CajonFruta:Cajon
    {
       public string tipo;

       public CajonFruta()
       {}



       public override void Mostrar()
       {
           Console.WriteLine("Tipo : " + this.tipo);
       }
    }
}
