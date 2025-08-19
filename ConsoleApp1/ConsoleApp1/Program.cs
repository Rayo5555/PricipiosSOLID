using System;

namespace ConsoleApp1
{

    public class FizzBuzz
    {
        public string check (int n)
        {
            if(n%3 == 0 && n%5 == 0)
            {
                return "fizzbuzz";
            }else if (n%3 == 0)
            {
                return "fizz";
            }else if (n%5 == 0)
            {
                return "buzz";
            }else
            {
                return n.ToString();
            }
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
