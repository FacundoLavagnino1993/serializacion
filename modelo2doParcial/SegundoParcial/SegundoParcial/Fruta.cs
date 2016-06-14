using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial
{
    public abstract class Fruta
    {
        protected ConsoleColor _color;
        protected float _peso;

        public abstract bool TieneCarozo
        {
            get;
        }

        public Fruta()
        { }

        public Fruta(float peso, ConsoleColor color)
        {
            this._color = color;
            this._peso = peso;
        }

        protected virtual string FrutaToString()
        {
            return string.Concat("Color: " + this._color + " Peso: " + this._peso);
        }

        public int OrdenarPorPesoAsc(Fruta f1, Fruta f2)
        { 
            
        }

        public int OrdenarPorPesoDesc(Fruta f1, Fruta f2)
        { }


    }
}
