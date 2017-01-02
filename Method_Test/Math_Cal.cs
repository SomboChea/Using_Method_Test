using System;
using MathMS;

namespace Method_Test
{
    class Math_Cal
    {
        static bool save_setting = false;

        static bool setting(bool name)
        {
            if(name == true)
            {
                save_setting = name;
            }else
            {
                save_setting = name;
            }
            return save_setting;
        }

        static void Main()
        {
            //SumMin = 1-2+3-4+5...+-(n);
            //Fibonacci = 1+1+2+3+5...(n-1)+(n-2);
            //PowX = 1*2*3*4*5...*n;
            //FactFib = 1!/1+2!/1+3!/2+4!/3+5!/5.....+(n!)/((n-1)+(n-2));
            
            
            int n=0;
            again:
            math ma = new math();
            
            //Show Menu
            Console.WriteLine("\t       ___               _            ___  _               ");
            Console.WriteLine("\t      / __|  ___  _ __  | |__  ___   / __|| |_   ___  __ _ ");
            Console.WriteLine("\t      \\__ \\ / _ \\| '  \\ | '_ \\/ _ \\ | (__ | ' \\ / -_)/ _' |");
            Console.WriteLine("\t      |___/ \\___/|_|_|_||_.__/\\___/  \\___||_||_|\\___|\\__,_|\n\n");
            
            Console.WriteLine("\t::======================== MAIN MENU ========================::");
            Console.WriteLine("\t::                                                           ::");
            Console.WriteLine("\t::      1. 1-2+3-4+5.....+-(n)                               ::");
            Console.WriteLine("\t::                                                           ::");
            Console.WriteLine("\t::      2. 1*2*3*4*5.....*n                                  ::");
            Console.WriteLine("\t::                                                           ::");
            Console.WriteLine("\t::      3. 1+1+2+3+5.....(n-1)+(n-2)                         ::");
            Console.WriteLine("\t::                                                           ::");
            Console.WriteLine("\t::      4. 1!/1+2!/1+3!/2+4!/3+5!/5.....+(n!)/((n-1)+(n-2))  ::");
            Console.WriteLine("\t::                                                           ::");
            Console.WriteLine("\t::===========================================================::\n");
            Console.WriteLine("\t                       n = {0}",n );

            if (n==0)
            {
                Console.SetCursorPosition(35, 18);
                n = int.Parse(Console.ReadLine());
            }
            Console.Write("\n\tEnter option number : ");
            int option = int.Parse(Console.ReadLine());

            if (save_setting == true)
            {
                switch (option)
                {
                    case 1:
                        Console.Write("\n\tSUM MINUS => ");
                        Console.Write(" " + ma.SumMin(n));
                        break;
                    case 2:
                        Console.Write("\n\tPOWER X => ");
                        Console.Write(" " + ma.PowX(n));
                        break;
                    case 3:
                        Console.Write("\n\tFIBONACCI => ");
                        Console.Write(" " + ma.Fibonacci(n));
                        break;
                    case 4:
                        Console.Write("\n\tFACTORIAL FIB => ");
                        Console.Write(" " + ma.FactFib(n));
                        break;
                    default:
                        Console.Clear();
                        goto again;
                        break;
                }
            }
            else
            {
                switch (option)
                {
                    case 1:
                        Console.Write("\n\tSUM MINUS => ");
                        ma.display("SumMin", n);
                        Console.Write(" = " + ma.SumMin(n));
                        break;
                    case 2:
                        Console.Write("\n\tPOWER X => ");
                        ma.display("PowX", n);
                        Console.Write(" = " + ma.PowX(n));
                        break;
                    case 3:
                        Console.Write("\n\tFIBONACCI => ");
                        ma.display("Fibonacci", n);
                        Console.Write(" = " + ma.Fibonacci(n));
                        break;
                    case 4:
                        Console.Write("\n\tFACTORIAL FIB => ");
                        ma.display("FactFib", n);
                        Console.Write(" = " + ma.FactFib(n));
                        break;
                    default:
                        Console.Clear();
                        goto again;
                        break;
                }
            }
            again_after_saved:
            Console.ReadKey();
            again_back_seeting:
            Console.Clear();
            Console.WriteLine("\t       ___               _            ___  _               ");
            Console.WriteLine("\t      / __|  ___  _ __  | |__  ___   / __|| |_   ___  __ _ ");
            Console.WriteLine("\t      \\__ \\ / _ \\| '  \\ | '_ \\/ _ \\ | (__ | ' \\ / -_)/ _' |");
            Console.WriteLine("\t      |___/ \\___/|_|_|_||_.__/\\___/  \\___||_||_|\\___|\\__,_|\n\n");

            Console.WriteLine("\t::========================= SUBMENU =========================::");
            Console.WriteLine("\t::                                                           ::");
            Console.WriteLine("\t::      a. Choose number again                               ::");
            Console.WriteLine("\t::                                                           ::");
            Console.WriteLine("\t::      b. Enter n again                                     ::");
            Console.WriteLine("\t::                                                           ::");
            Console.WriteLine("\t::      c. Exit                                              ::");
            Console.WriteLine("\t::                                                           ::");
            Console.WriteLine("\t::      s. Setting                                           ::");
            Console.WriteLine("\t::                                                           ::");
            Console.WriteLine("\t::===========================================================::\n");
            Console.WriteLine("\t                Choose character = ");
            again_opt:
            Console.SetCursorPosition(43, 18);
            char opt = char.Parse(Console.ReadLine());

            switch (opt)
            {
                case 'a':
                    Console.Clear();
                    goto again;
                    break;
                case 'b':
                    Console.Clear();
                    n = 0;
                    goto again;
                    break;
                case 'c':
                    System.Environment.Exit(0);
                    break;
                case 's':
                    goto setting;
                    break;
                default:
                    goto again_opt;
                    break;
            }

            setting:
            string[] saved_msg = {"","" };
            if (save_setting == true)
            {
                saved_msg[1] = "(Default)";
            } else
            {
                saved_msg[0] = "(Default)";
            }
            Console.WriteLine("\n\t1. LONG RESULT " + saved_msg[0]);
            Console.WriteLine("\t2. SHORT RESULT " + saved_msg[1]);
            Console.WriteLine("\t0. BACK \n");
            again_saved_default:
            Console.Write("\tEnter number: ");
            int num_set = int.Parse(Console.ReadLine());
            switch (num_set)
            {
                case 1:
                    setting(false);
                    Console.Write("\tSaved to LONG RESULT!");
                    break;
                case 2:
                    setting(true);
                    Console.Write("\tSaved to SHORT RESULT!");
                    break;
                case 0:
                    goto again_back_seeting;
                    break;
                default:
                    goto again_saved_default;
                    break;
            }
            goto again_after_saved;
            Console.ReadKey();
        }
    }
}
