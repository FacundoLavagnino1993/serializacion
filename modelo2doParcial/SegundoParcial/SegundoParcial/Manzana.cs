using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial
{
    public class Manzana:Fruta
    {
        public double precio;

        public Manzana()
        { }

        public Manzana(float peso, ConsoleColor color, double Precio)
            : base(peso, color)
        {
            this.precio = Precio;
        }


        public override bool TieneCarozo
        {
            get { return true; }
        }

        public string Tipo
        {
            get { return "Manzana"; }
        }

        protected override string FrutaToString()
        {
            return string.Concat("\nTipo: " + this.Tipo + base.FrutaToString() + " Precio: " + this.precio);
        }

        public string ToString()
        {
            return this.FrutaToString();
        }



    }
}
