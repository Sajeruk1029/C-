using System;
using System.Threading;

namespace Prakt6
{
    class Program
    {

        static void task_one()
        {

            int[] mass = new int[10];
            int count;
            Random rand = new Random();

            for (count = 0; count < 10; count++)
            {

                mass[count] = rand.Next(1, 100);

            }

            for (count = 0; count < 10; count++)
            {

                if (mass[count] < mass[9])
                {

                    Console.WriteLine(mass[count]);

                }

            }

            if (Console.CursorTop == 0)
            {

                Console.WriteLine(0);
            }

        }

        static void task_two()
        {

            int k, n, count;
            Random rand = new Random();

            Console.WriteLine("Введите целое число n(n > 0)...");

            while (((!int.TryParse(Console.ReadLine(), out n))) || (n <= 0))
            {

                Console.WriteLine("Введено значение не соответствующие условию.");

            }


            int[] mass = new int[n];
            int[] mass2 = new int[n - 1];

            Console.WriteLine();

            for (count = 0; count < mass.Length; count++)
            {

                mass[count] = rand.Next(0, 100);

            }
            for (count = 0; count < mass.Length; count++)
            {

                Console.WriteLine(mass[count]);

            }

            Console.WriteLine("Введите целое число k(1 < k < n)...");

            while ((!(int.TryParse(Console.ReadLine(), out k))) || (k <= 1) || (k >= n))
            {

                Console.WriteLine("Введено значение не соответствующие условию.");

            }

            Console.WriteLine();

            for (count = 0; count < mass.Length; count++)
            {

                if (count == k - 1)
                {


                    mass[count] = 0;

                }

            }

            for (count = 0; count < mass.Length; count++)
            {

                Console.WriteLine(mass[count]);

            }

        }

        static void task_three()
        {

            int count, posone, postwo, sum;
            int[] mass = new int[10];
            Random rand = new Random();

            posone = 0;
            postwo = 0;
            sum = 0;

            for (count = 0; count < 10; count++)
            {

                mass[count] = rand.Next(-100, 100);

            }

            for (count = 0; count < 10; count++)
            {

                if (mass[count] < 0)
                {

                    posone = count;
                    break;

                }

            }

            for (count = 0; count < 10; count++)
            {

                if (mass[count] < 0)
                {

                    postwo = count;

                }

            }

            for (count = 0; count < 10; count++)
            {

                Console.WriteLine(mass[count]);

            }

            Console.WriteLine();

            for (count = posone; count <= postwo; count++)
            {

                sum += mass[count];

            }

            Console.WriteLine(sum);

        }

        static void task_four()
        {

            int[] mass1 = new int[10];
            int[] mass2 = new int[10];

            int count, rezerv;
            Random rand = new Random();

            for (count = 0; count < 10; count++)
            {

                mass1[count] = rand.Next(0, 100);
                mass2[count] = rand.Next(0, 100);

            }

            for (count = 0; count < 10; count++)
            {

                rezerv = mass1[count];
                mass1[count] = mass2[count];
                mass2[count] = rezerv;

            }

            for (count = 0; count < 10; count++)
            {

                Console.WriteLine(mass1[count]);

            }

            Console.WriteLine();

            for (count = 0; count < 10; count++)
            {

                Console.WriteLine(mass2[count]);

            }

        }

        static void choose()
        {

            ConsoleKeyInfo key;

            while (true)
            {

                key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow)
                {

                    if (Console.CursorTop == 0)
                    {

                        Console.SetCursorPosition(0, 3);

                    }
                    else
                    {

                        Console.SetCursorPosition(0, Console.CursorTop - 1);

                    }

                }

                if (key.Key == ConsoleKey.DownArrow)
                {

                    if (Console.CursorTop == 3)
                    {

                        Console.SetCursorPosition(0, 0);

                    }
                    else
                    {

                        Console.SetCursorPosition(0, Console.CursorTop + 1);

                    }

                }

                if (key.Key == ConsoleKey.Enter)
                {

                    switch (Console.CursorTop)
                    {

                        case 0:
                            {

                                Console.Clear();
                                task_one();
                                //break;
                                return;

                            }

                        case 1:
                            {

                                Console.Clear();
                                task_two();
                                //break;
                                return;

                            }

                        case 2:
                            {

                                Console.Clear();
                                task_three();
                                //break;
                                return;

                            }

                        case 3:
                            {

                                Console.Clear();
                                task_four();
                                //break;
                                return;


                            }

                    }

                }

            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine(" Задача первая.");
            Console.WriteLine(" Задача вторая.");
            Console.WriteLine(" Задача третья.");
            Console.WriteLine(" Задача четвертая.");

            Console.SetCursorPosition(0, 0);

            Thread potok = new Thread(choose);
            potok.Start();

            //task_one();
            //task_two();
            //task_three();
            //task_four();

        }
    }
}
