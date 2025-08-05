using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public List<int> Notas { get; set; }

        public double CalcularPromedio()
        {
            return Notas.Average();
        }

        public void ImprimirInformacion()
        {
            Console.WriteLine($"Estudiante: {Nombre}, Promedio: {CalcularPromedio()}");
        }

        public bool EstaAprobado()
        {
            return CalcularPromedio() >= 6;
        }
    }

}
