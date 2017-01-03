//Group : SN1 | CHEA SAMBO

using System;
using MathMS;

namespace Method_Test
{
    public class Math_Cal
    {
        static bool save_setting = false;
        static string save_latest_result;

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

        static string setLatestSaved(string res)
        {
            save_latest_result = res;
            return save_latest_result;
        }

        public void MainMethod(string[] args)
        {
            if (args[4] == "main")
            {
                //SumMin = 1-2+3-4+5...+-(n);
                //Fibonacci = 1+1+2+3+5...(n-1)+(n-2);
                //PowX = 1*2*3*4*5...*n;
                //FactFib = 1!/1+2!/1+3!/2+4!/3+5!/5.....+(n!)/((n-1)+(n-2));


                int n = 0;
                string res = "";
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
                Console.WriteLine("\t                       n = {0}", n);

                if (n == 0)
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
                            res = " " + ma.SumMin(n);
                            setLatestSaved(res);
                            break;
                        case 2:
                            Console.Write("\n\tPOWER X => ");
                            Console.Write(" " + ma.PowX(n));
                            res = " " + ma.PowX(n);
                            setLatestSaved(res);
                            break;
                        case 3:
                            Console.Write("\n\tFIBONACCI => ");
                            Console.Write(" " + ma.Fibonacci(n));
                            res = " " + ma.Fibonacci(n);
                            setLatestSaved(res);
                            break;
                        case 4:
                            Console.Write("\n\tFACTORIAL FIB => ");
                            Console.Write(" " + ma.FactFib(n));
                            res = " " + ma.FactFib(n);
                            setLatestSaved(res);
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
                            res = ma.getRes() + " = " + ma.SumMin(n);
                            setLatestSaved(res);
                            break;
                        case 2:
                            Console.Write("\n\tPOWER X => ");
                            ma.display("PowX", n);
                            Console.Write(" = " + ma.PowX(n));
                            res = ma.getRes() + " = " + ma.PowX(n);
                            setLatestSaved(res);
                            break;
                        case 3:
                            Console.Write("\n\tFIBONACCI => ");
                            ma.display("Fibonacci", n);
                            Console.Write(" = " + ma.Fibonacci(n));
                            res = ma.getRes() + " = " + ma.Fibonacci(n);
                            setLatestSaved(res);
                            break;
                        case 4:
                            Console.Write("\n\tFACTORIAL FIB => ");
                            ma.display("FactFib", n);
                            Console.Write(" = " + ma.FactFib(n));
                            res = ma.getRes() + " = " + ma.FactFib(n);
                            setLatestSaved(res);
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
                Console.WriteLine("\t::      p. Show Latest Result                                ::");
                Console.WriteLine("\t::                                                           ::");
                Console.WriteLine("\t::      s. Setting                                           ::");
                Console.WriteLine("\t::                                                           ::");
                Console.WriteLine("\t::===========================================================::\n");
                Console.WriteLine("\t                Choose character = ");
            again_opt:
                Console.SetCursorPosition(43, 20);
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
                    case 'p':
                        goto show_latest_res;
                        break;
                    case 's':
                        goto setting;
                        break;
                    default:
                        goto again_opt;
                        break;
                }

            setting:
                string[] saved_msg = { "", "" };
                if (save_setting == true)
                {
                    saved_msg[1] = "(Default)";
                }
                else
                {
                    saved_msg[0] = "(Default)";
                }
                Console.WriteLine("\n\t1. LONG RESULT " + saved_msg[0]);
                Console.WriteLine("\n\t2. SHORT RESULT " + saved_msg[1]);
                Console.WriteLine("\n\t3. RESET ALL ");
                Console.WriteLine("\n\t0. BACK \n");
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
                    case 3:
                        setting(false);
                        setLatestSaved(null);
                        Console.Write("\tAll values were resetted!");
                        goto again_after_saved;
                        break;
                    case 0:
                        goto again_back_seeting;
                        break;
                    default:
                        goto again_saved_default;
                        break;
                }

                goto again_after_saved;

            show_latest_res:
                if (save_latest_result != null)
                {
                    Console.WriteLine("\n\tLatest Result is : " + save_latest_result);
                    goto again_after_saved;
                }
                else
                {
                    Console.WriteLine("\n\tYou don't have saved!");
                    goto again_after_saved;
                }

                Console.ReadKey();

            } else
            {
                Console.WriteLine("\n\tYou don't have enough permission to use \n\n\tthis program, or it error on arguments!\n\n\tPlease set it to \"main\" \n\n\tGood bye!!!");
                Console.ReadKey();
            }
        }
    }
}
