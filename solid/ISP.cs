using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid
{
    public interface IAnimal
    {
        void Caminar();
        void Nadar();
        void Volar();
    }
        
    public class Pez : IAnimal
    {
        public void Caminar() => throw new NotImplementedException();
        public void Nadar() => Console.WriteLine("Nadando...");
        public void Volar() => throw new NotImplementedException();
    }

}
