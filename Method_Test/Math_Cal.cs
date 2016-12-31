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
            //SumMin = 1-2+3-4+5...+-(n);
            //Fibonacci = 1+1+2+3+5...(n-1)+(n-2);
            //PowX = 1*2*3*4*5...*n;
            //FactFib = 1!/1+2!/1+3!/2+4!/3+5!/5.....+(n!)/((n-1)+(n-2));

            int n;
            again:
            Console.Write("Enter n : ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            math ma = new math();

            //Show Menu
            again_num:
            Console.WriteLine("Main Menu\n");
            Console.WriteLine("1. 1-2+3-4+5.....+-(n)\n");
            Console.WriteLine("2. 1*2*3*4*5.....*n\n");
            Console.WriteLine("3. 1+1+2+3+5.....(n-1)+(n-2)\n");
            Console.WriteLine("4. 1!/1+2!/1+3!/2+4!/3+5!/5.....+(n!)/((n-1)+(n-2))\n");
            Console.Write("Enter option : ");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("\n");
                    ma.display("SumMin", n);
                    Console.Write(" = " + ma.SumMin(n));
                    Console.WriteLine("\n");
                    break;
                case 2:
                    Console.WriteLine("\n");
                    ma.display("PowX", n);
                    Console.Write(" = " + ma.PowX(n));
                    Console.WriteLine("\n");
                    break;
                case 3:
                    Console.WriteLine("\n");
                    ma.display("Fibonacci", n);
                    Console.Write(" = " + ma.Fibonacci(n));
                    Console.WriteLine("\n");
                    break;
                case 4:
                    Console.WriteLine("\n");
                    ma.display("FactFib", n);
                    Console.Write(" = " + ma.FactFib(n));
                    Console.WriteLine("\n");
                    break;
                default:
                    Console.WriteLine("\nUnknow option!\n");
                    break;
            }

            Console.WriteLine("\nSub Main\n");
            Console.WriteLine("a. Choose number again\n");
            Console.WriteLine("b. Enter n again\n");
            Console.WriteLine("c. Exit\n");
            again_opt:
            Console.Write("Choose character : ");
            char opt = char.Parse(Console.ReadLine());

            switch (opt)
            {
                case 'a':
                    Console.Clear();
                    goto again_num;
                    break;
                case 'b':
                    Console.Clear();
                    goto again;
                    break;
                case 'c':
                    System.Environment.Exit(0);
                    break;
                default:
                    goto again_opt;
                    break;
            }

            Console.ReadKey();
        }
    }
}
