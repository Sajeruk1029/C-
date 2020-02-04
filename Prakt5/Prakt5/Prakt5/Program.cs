using System;
using System.Threading;


namespace Prakt5
{

    //(c+4*d-sqrt(123))/(1 - a / 2)

    class Program
    {


        static double a;
        static double d;
        static double c;


        static void first()
        {

            double a, d, c;
            //Console.WriteLine("Введете значения...");

            Console.WriteLine("Введите первое значение...");

            while (!(double.TryParse(Console.ReadLine(), out a)))
            {

                Console.WriteLine("Введено не число...");

            }

            Console.WriteLine("Введите второе значение...");

            while (!(double.TryParse(Console.ReadLine(), out d)))
            {

                Console.WriteLine("Введено не число...");

            }

            Console.WriteLine("Введите третье значение...");

            while (!(double.TryParse(Console.ReadLine(), out c)))
            {

                Console.WriteLine("Введено не число...");

            }


            Console.WriteLine((c + 4 * d - Math.Sqrt(123)) / (1 - a / 2));


        }

        static void second(double a, double d, double c)
        {


            Console.WriteLine((c + 4 * d - Math.Sqrt(123)) / (1 - a / 2));

        }

        static double theerd(double a, double d, double c)
        {

            return ((c + 4 * d - Math.Sqrt(123)) / (1 - a / 2));

        }

        static double four(ref double a, ref double d, ref double c)
        {



            return ((c + 4 * d - Math.Sqrt(123)) / (1 - a / 2));

        }

        static void choose_check()
        {

            double a, d, c;
            ConsoleKeyInfo key;

            while (true)
            {

                key = Console.ReadKey();



                if ((key.Key == ConsoleKey.UpArrow))
                {

                    if (Console.CursorTop == 0)
                    {

                        Console.SetCursorPosition(0, 3);

                    }

                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);

                }

                if ((key.Key == ConsoleKey.DownArrow))
                {

                    if (Console.CursorTop == 3)
                    {

                        Console.SetCursorPosition(0, 0);

                    }

                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 1);

                }

                if (key.Key == ConsoleKey.Enter)
                {

                    switch (Console.CursorTop)
                    {

                        case 0:
                            {

                                Console.Clear();
                                first();
                                return;

                            }

                        case 1:
                            {
                                Console.Clear();
                                Console.WriteLine("Введите первое значение...");

                                while (!(double.TryParse(Console.ReadLine(), out a)))
                                {

                                    Console.WriteLine("Введено не число...");

                                }

                                Console.WriteLine("Введите второе значение...");

                                while (!(double.TryParse(Console.ReadLine(), out d)))
                                {

                                    Console.WriteLine("Введено не число...");

                                }

                                Console.WriteLine("Введите третье значение...");

                                while (!(double.TryParse(Console.ReadLine(), out c)))
                                {

                                    Console.WriteLine("Введено не число...");

                                }

                                Console.WriteLine("Введите значения...");
                                second(a, d, c);
                                return;

                            }

                        case 2:
                            {
                                Console.Clear();
                                Console.WriteLine("Введите первое значение...");

                                while (!(double.TryParse(Console.ReadLine(), out a)))
                                {

                                    Console.WriteLine("Введено не число...");

                                }

                                Console.WriteLine("Введите второе значение...");

                                while (!(double.TryParse(Console.ReadLine(), out d)))
                                {

                                    Console.WriteLine("Введено не число...");

                                }

                                Console.WriteLine("Введите третье значение...");

                                while (!(double.TryParse(Console.ReadLine(), out c)))
                                {

                                    Console.WriteLine("Введено не число...");

                                }

                                Console.WriteLine("Введите значения...");
                                Console.WriteLine(theerd(a, d, c));
                                return;

                            }

                        case 3:
                            {

                                Console.Clear();
                                //Console.WriteLine("Введете значения...");

                                Console.WriteLine("Введите первое значение...");

                                while (!(double.TryParse(Console.ReadLine(), out a)))
                                {

                                    Console.WriteLine("Введено не число...");

                                }

                                Console.WriteLine("Введите второе значение...");

                                while (!(double.TryParse(Console.ReadLine(), out d)))
                                {

                                    Console.WriteLine("Введено не число...");

                                }

                                Console.WriteLine("Введите третье значение...");

                                while (!(double.TryParse(Console.ReadLine(), out c)))
                                {

                                    Console.WriteLine("Введено не число...");

                                }

                                Console.WriteLine(four(ref a, ref c, ref d));
                                return;

                            }
                    }


                }


            }

        }

        static void choose_ent()
        {

            ConsoleKeyInfo key;

            while (true)
            {

                key = Console.ReadKey();


            }

        }


        static void Main(string[] args)
        {


            Thread potok = new Thread(choose_check);
            //Thread potok2 = new Thread(choose_ent);
            potok.Start();
            //potok2.Start();

            //first();
            //second(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            //Console.WriteLine(theerd(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));
            //Console.WriteLine(four(ref a,ref d,ref c));
            Console.WriteLine("1. Функция без аргументов и ничего не возвращает.");
            Console.WriteLine("2. Функция с аргументами и ничего не возвращает.");
            Console.WriteLine("3. Функция с аргументами и возвращает аргументов.");
            Console.WriteLine("4. Возвращает значение рефом.");
            Console.SetCursorPosition(0, 0);

        }
    }
}
