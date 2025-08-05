using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid
{
    public class Televisor
    {
        public void Encender() => Console.WriteLine("TV encendida.");
    }

    public class ControlRemoto
    {
        private Televisor tv = new Televisor();

        public void EncenderDispositivo()
        {
            tv.Encender();
        }
    }

}
