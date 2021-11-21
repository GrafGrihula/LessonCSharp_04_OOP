using System;
using System.Numerics;

namespace ComplexNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1 = new Complex(17.34, 12.87);
            Console.WriteLine(complex1.ToString());

            Complex complex2 = new Complex(8.76, 5.19);
            Console.WriteLine(complex2.ToString());

            Console.WriteLine("{0} + {1} = {2}", complex1, complex2, complex1 + complex2);
            Console.WriteLine("{0} - {1} = {2}", complex1, complex2, complex1 - complex2);
            Console.WriteLine("{0} * {1} = {2}", complex1, complex2, complex1 * complex2);
            Console.WriteLine("{0} / {1} = {2}", complex1, complex2, complex1 / complex2);

            Console.WriteLine(complex1.Equals(complex2));
        }
    }
}
