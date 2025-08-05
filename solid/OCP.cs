using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid
{
    public class Descuento
    {
        public double Calcular(string tipoCliente, double total)
        {
            if (tipoCliente == "Regular")
                return total * 0.05;
            else if (tipoCliente == "Premium")
                return total * 0.10;
            else
                return 0;
        }
    }

}
