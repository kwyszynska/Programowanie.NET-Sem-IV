using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia_2405
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nested.Calculate Calculate = new Nested.Calculate();
            Calculate.squareRoot(3); 
            Calculate.squareRoot(5); 
            Calculate.squareRoot(37);
            Console.ReadKey();
        }
    }
}
