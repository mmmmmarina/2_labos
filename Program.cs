using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex a = new Complex(1, 2);
            Complex b = new Complex(3, 4);
            Complex c = a + b;

            QuadraticEquation qa1 = new QuadraticEquation();
            QuadraticEquation qa2 = new QuadraticEquation(1, 2, -3);
            QuadraticEquation qa3 = new QuadraticEquation(-1, 2, -1);
            QuadraticEquation qa4 = new QuadraticEquation(1, 0, 1);

            Console.WriteLine(qa1);
            qa1.A = 5;
            qa1.C = 4;

            Console.WriteLine($"{qa1.A}, {qa1.B}, {qa1.C} = {qa1.Y(2)}");
            Console.WriteLine($"{qa2.A}, {qa2.B}, {qa2.C} = {qa2.Y(1)}");
            Console.WriteLine($"Discriminant: {qa2.Discriminant}");
            Console.WriteLine($"Discriminant: {qa3.Discriminant}");
            Console.WriteLine($"Discriminant: {qa4.Discriminant}");
            Console.WriteLine($"Root: {qa2.Roots[0]}, {qa2.Roots[1]}");
            Console.WriteLine($"Root: {qa3.Roots[0]}, {qa3.Roots[1]}");
            try
            {
                Console.WriteLine($"Root: {qa4.Roots}");
            }
            catch (NotRealRootsException e)
            {
                Console.WriteLine("Not real roots");
            }


            Console.ReadKey();
        }
    }
}
