using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploArchivos
{
    class BackUp
    {
        public static bool HacerBackup(Iserializable I)
        {
            return I.guardarEnXml();
        }
    }
}
