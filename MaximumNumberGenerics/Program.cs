using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumberGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Maximum Number Program using Generics");
            Console.WriteLine("Find max Number");
            MaximumNumberCheck MaxInt = new MaximumNumberCheck();
            int output = MaxInt.MaximumIntegerNumber(11, 22, 33);
            Console.WriteLine(output);
            float floatoutput = MaxInt.MaximumFloatNumber(111.2f, 22.45f, 78.56f);
            Console.WriteLine(floatoutput);
        }
    }
}
