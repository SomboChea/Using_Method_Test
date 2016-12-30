using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathMS;

namespace Method_Test
{
    class Math_Cal
    {
        
        static void Main()
        {
            int n;
            Console.Write("Enter n : ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            //SumMin = 1-2+3-4+5...+-(n);
            //Fibonacci = 1+1+2+3+5...(n-1)+(n-2);
            //PowX = 1*2*3*4*5...*n;
            //FactFib = 1!/1+2!/1+3!/2+4!/3+5!/5.....+(n!)/((n-1)+(n-2));

            math ma = new math();
            ma.display("Fibonacci", n);
            Console.Write(" = " + ma.Fibonacci(n));
            Console.WriteLine("\n");
            ma.display("SumMin", n);
            Console.Write(" = " + ma.SumMin(n));
            Console.WriteLine("\n");
            ma.display("PowX", n);
            Console.Write(" = " + ma.PowX(n));
            Console.WriteLine("\n");
            ma.display("FactFib", n);
            Console.Write(" = " + ma.FactFib(n));

            Console.WriteLine("\n\nMain Menu\n");
            Console.WriteLine("1. 1-2+3-4+5.....+-(n)\n");
            Console.WriteLine("2. 1*2*3*4*5.....*n\n");
            Console.WriteLine("3. 1+1+2+3+5.....(n-1)+(n-2)\n");
            Console.WriteLine("4. 1!/1+2!/1+3!/2+4!/3+5!/5.....+(n!)/((n-1)+(n-2))\n");

            Console.Read();

            Console.WriteLine("\nSub Main\n");
            Console.WriteLine("a. Choose number again\n");
            Console.WriteLine("b. Enter n again\n");
            Console.WriteLine("c. Exit\n");
            Console.Write("Choose character : ");

            Console.ReadKey();
        }
    }
}
