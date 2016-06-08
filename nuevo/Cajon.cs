using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjemploArchivos;
using System.Xml;
using System.Xml.Serialization;
using System.IO;


namespace nuevo
{
    [XmlInclude(typeof(CajonVerdura))]
    [XmlInclude(typeof(CajonFruta))]

    public abstract class Cajon:Iserializable
    {
        private float precio;

        public float Precio
        {
            set { this.precio = value; }
            get { return this.precio; }
        }

        public abstract void Mostrar();
        


        public string ToString()
        { return ""; }

        public bool guardarEnXml()
        {
            bool r = false;
            try
            {
                using (XmlTextWriter esc = new XmlTextWriter("ListaCajon.xml", Encoding.UTF8))
                { 
                    XmlSerializer serializar = new XmlSerializer(typeof(Cajon));
                    serializar.Serialize(esc, this);
                }
                r = true;
            }
            catch (Exception ex)
            {
                    Console.WriteLine(ex.Message);
                    r = false;
            }

            return r;

        }
    }
}
