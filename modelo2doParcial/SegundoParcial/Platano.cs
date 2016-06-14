using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial
{
    public class Platano:Fruta
    {

        public double precio;

        public Platano()
        { }

        public Platano(float peso, ConsoleColor color, double Precio)
            : base(peso, color)
        {
            this.precio = Precio;
        }


        public override bool TieneCarozo
        {
            get { return false; }
        }

        public string Tipo
        {
            get { return "Platano"; }
        }

        protected override string FrutaToString()
        {
            return string.Concat("\nTipo: "+this.Tipo + base.FrutaToString() + " Precio: " + this.precio);
        }

        public string ToString()
        {
            return this.FrutaToString();
        }

    }
}
