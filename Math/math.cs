using System;

namespace MathMS
{
    public class math
    {
        public double Abs(double a)
        {
            if (a < 0)
            {
                a = a * (-1);
            }
            return a;
        }

        public double Pow(double a, double b)
        {
            double pow = 1;
            for (int i = 1; i <= b; i++)
            {
                pow *= a;
            }
            return pow;
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }

        public double Exp(double a)
        {
            double e = 2.718, pow_e = 1;
            for (int i = 1; i <= a; i++)
            {
                pow_e *= e;
            }
            return pow_e;
        }

        public int Ceiling(double a)
        {
            int a_up = (int)a;
            if (a > a_up)
            {
                return a_up += 1;
            } else
            {
                return a_up;
            }
        }

        public int Floor(double a)
        {
            return (int)a;
        }

        private const double pI = 3.14;

        public double PI()
        {
            return pI;
        }
        
        public double Max(double a, double b)
        {
            if (a > b)
            {
                return a;
            } else
            {
                return b;
            }
        }

        public double Min(double a, double b)
        {
            if (a < b)
            {
                return a;
            }else
            {
                return b;
            }
        }

        public double perimeter(int w, int h)
        {
            double p = (w + h) * 2;
            return p;
        }

        //PowX = 1*2*3*4*5...*n;
        public double PowX(int n)
        {
            double powX = 1;
            for(int i = 1; i <= n; i++)
            {
                powX *= i;
            }
            return powX;
        }

        //Fibonacci = 1+1+2+3+5...(n-1)+(n-2);
        public double Fibonacci(int n)
        {
            int a=1, b=1, c;
            double Fib = a+b;
            for(int i = 0; i < n-2; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Fib += c;

            }
            return Fib;
        }

        //SumMin = 1-2+3-4+5...+-(n);
        public double SumMin(int n)
        {
            double sumMi = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    sumMi -= i;
                else
                    sumMi += i;
            }

            return sumMi;
        }

        //FactFib = 1!/1+2!/1+3!/2+4!/3+5!/5.....+(n!)/((n-1)+(n-2));
        public double FactFib(int n)
        {
            double factFib = 0, fact = 1;
            int a = 1, b = 1, c, d = 1;
            for (int j = 1; j <= n; j++)
            {
                c = a + b;
                a = b;
                if (j > 2)
                {
                    fact *= j;
                    factFib += fact / c;
                    b = c;
                }
                else
                {
                    fact *= j;
                    factFib += fact / d;
                }
            }
            return factFib;
        }

        public void display(string name, int n)
        {
            string[] names = new string[] { "SumMin", "Fibonacci","PowX","FactFib" };
            if (name == names[0])
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("-" +i);
                    }
                    else
                    {
                        if (i == 1)
                            Console.Write(i);
                        else
                            Console.Write("+" +i);
                    }
                }
            }
            else  if (name == names[1])
            {
                int a = 1, b = 1, c;
                Console.Write(a + "+" + b);
                for (int i = 0; i < n - 2; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                    Console.Write("+" + c);
                }
            }
            else if (name == names[2])
            {
                for(int i = 1; i <= n; i++)
                {
                    Console.Write(i + "*");
                }
                Console.Write("\b");
            }
            else if (name == names[3])
            {
                int a = 1, b = 1, c,d=1;
                for(int j = 1; j <= n; j++)
                {
                    c = a + b;
                    a = b;
                    if (j > 2)
                    {
                        b = c;
                        Console.Write(j+"!/"+c+"+");
                    }
                    else
                    {
                        Console.Write(j + "!/" + d + "+");
                    }
                }
                Console.Write("\b");
            }
            else
            {
                Console.WriteLine("Unkonw type!");
            }
            
        }

    }
}
