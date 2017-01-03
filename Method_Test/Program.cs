using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathMS;

namespace Method_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Load Main Program
            Math_Cal mainLoad = new Math_Cal();
            args = new string[] { "tobeable", "thelight", "justgo", "justmymind", "main", "justrun","goaway","myprogram","mysigle","hilinto","debug","bug","method" };
            mainLoad.MainMethod(args);


            //far away;
            //Got method;
            //Only style;


            /* Other method in math
             * 

            double a, b;
            Console.Write("Enter a : ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Enter b : ");
            b = double.Parse(Console.ReadLine());
            math ma = new math();
            Console.WriteLine("Abs A : " + ma.Abs(a));
            Console.WriteLine("Abs B : " + ma.Abs(b));
            Console.WriteLine("Pow A^B : " + ma.Pow(a,b));
            Console.WriteLine("e^A : " + ma.Exp(a));
            Console.WriteLine("e^B : " + ma.Exp(b));
            Console.WriteLine("Ceiling A: " + ma.Ceiling(a));
            Console.WriteLine("Floor A: " + ma.Floor(a));
            Console.WriteLine("Ceiling B: " + ma.Ceiling(b));
            Console.WriteLine("Floor B: " + ma.Floor(b));
            Console.WriteLine("PI : " + ma.PI());
            Console.WriteLine("Max : " + ma.Max(a,b));
            Console.WriteLine("Min : " + ma.Min(a,b));
            Console.Read();

            *
            */
        }

    }
}
