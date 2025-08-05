using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid
{
    public class Ave
    {
        public virtual void Volar()
        {
            Console.WriteLine("Volando...");
        }
    }

    public class Pinguino : Ave
    {
        public override void Volar()
        {
            throw new NotImplementedException("Los pingüinos no vuelan.");
        }
    }

}
