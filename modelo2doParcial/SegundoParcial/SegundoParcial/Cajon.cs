using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial
{
    public class Cajon
    {
        private int _capacidad;
        private List<Fruta> _fruta;

        public Cajon()
        {
            this._fruta = new List<Fruta>(this._capacidad);
        }


        public List<Fruta> Frutas
        {
            get { return this._fruta; }
        }

        public double PrecioDeManzanas
        {
            get { return this.ObtenerTotal(EtipoFruta.Manzana); }
        }

        public double PrecioDePlatanos
        {
            get { return this.ObtenerTotal(EtipoFruta.Platano); }
        }

        public double PrecioTotal
        {
            get { return this.ObtenerTotal(EtipoFruta.Todo); }
        }

        private double ObtenerTotal(EtipoFruta tipo)
        {
            double rta = 0;
            if (EtipoFruta.Todo == tipo)
            {
                for (int i = 0; i < this.Frutas.Count; i++)
                {
                    if (this.Frutas[i] is Manzana)
                    {
                        rta += ((Manzana)this.Frutas[i]).precio;
                    }
                    else
                    {
                        rta += ((Platano)this.Frutas[i]).precio;
                    }

                }
            }

            else if (EtipoFruta.Manzana == tipo)
            {
                for (int i = 0; i < this.Frutas.Count; i++)
                {
                    if (this.Frutas[i] is Manzana)
                    {
                        rta += ((Manzana)this.Frutas[i]).precio;
                    }
                }

            }
            else 
            {
                for (int i = 0; i < this.Frutas.Count; i++)
                {
                    if (this.Frutas[i] is Platano)
                    {
                        rta += ((Platano)this.Frutas[i]).precio;
                    }
                }
            }

                //for (int i = 0; i < this.Frutas.Count; i++)
                //{
                //    if ((this.Frutas[i] is Manzana) && (tipo == EtipoFruta.Manzana))
                //    {
                //        rta += ((Manzana)this.Frutas[i]).precio;
                //    }
                //    else if ((this.Frutas[i] is Platano) && (tipo == EtipoFruta.Platano))
                //    {
                //        rta += ((Platano)this.Frutas[i]).precio;
                //    }
                //}

            return rta;
        }

        public string ToString()
        {
            return string.Concat("\nCapacidad : " + this._capacidad);
        }

        public static Cajon operator +(Cajon c, Fruta f)
        {
            
            
           c._fruta.Add(f);
           return new Cajon(
        }



    }

    enum EtipoFruta
    { Manzana,Platano,Todo, }

}
