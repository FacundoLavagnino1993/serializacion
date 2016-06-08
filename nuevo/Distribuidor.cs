using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuevo
{
    class Distribuidor
    {
        // Crear listado de cajones, como listado de transporte van a ser privados y tendran propiedad de solo lectura.
        private List<Transporte> listaDeTrans;
        private List<Cajon> listaCajon; 

        public List<Transporte> ListaTrans
        {
            get { return this.listaDeTrans; }
        }


        

        public List<Cajon> listCajon
        {
            get { return this.listaCajon; }
        }

        public Persona jefe;

        public Distribuidor()
        {
            this.listaDeTrans = new List<Transporte>();
            this.listaCajon = new List<Cajon>();
        }

        public Distribuidor(Persona Jefe, List<Cajon> ListaCajon, List<Transporte> ListaTransporte)
        {
            this.listaCajon = ListaCajon;
            this.listaDeTrans = ListaTransporte;
            this.jefe = Jefe;
        }

        
    }
}
