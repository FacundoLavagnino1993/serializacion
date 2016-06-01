using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploArchivosOK
{
    public abstract class serHumano
    {
        public string dni;
        public serHumano()
        { }

        public serHumano(string _dni)
        {
            this.dni = _dni;

        }
    }
}
