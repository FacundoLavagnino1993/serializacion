using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuevo
{
    public class Profesional:Conductor
    {
        public string nroLic;
        public string vencimiento;
        public Profesional()
        { }

        public Profesional(string lic, string venci, string nom, string ape, int dni)
            :base(nom, ape, dni) //Constructor que recibe licencia y vencimiento por parametro, ademas 
        {
            this.nroLic = lic;
            this.vencimiento = venci;
        }

        private void calculaVen(string fechaexp) //Metodo para verificar si la licencia esta vencida. Recibe por parametro un string (dd/mm/aaaa)
        {
            
            DateTime exp = DateTime.Parse(fechaexp); //Creamos obj datetime, y usamos el metodo parse para convertir string en DateTime.
            if((exp.CompareTo(DateTime.Today))==-1) // Comparamos con el metodo CompareTo, que recibe la fecha actual. Esto retorna 1 si el string es mayor a la fecha actual.
            {
                Console.WriteLine("La licencia del chofer ha vencido.");
            }
            else if((exp.CompareTo(DateTime.Today)==0))//En caso de tener una coincidencia entre la fecha por parametro y la fecha del dia, indica que la licencia vence en el dia.
            {
                Console.WriteLine("La licencia del chofer vence hoy.");
            }
            else
            {
                Console.WriteLine("La licencia del chofer todavia no vencio.");
            }
            
        }

        
        public void Mostrar()
        {
            this.calculaVen(this.vencimiento);
        }
    }
}
