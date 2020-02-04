using System;
using System.Threading;

namespace Prakt3
{
    class Program
    {

        public static void task_one(int rangeDown = -34, int rangeUp = -161)
        {

            int sum, count, kol;
            double result = 0.0d;
            sum = 0;
            kol = 1;


            if (rangeDown < rangeUp)
            {

                for (count = rangeDown; count <= rangeUp; count++)
                {


                    sum += count;
                    //Console.WriteLine(sum);
                    //Console.WriteLine(kol);
                    kol++;

                }

            }
            else
            {

                for (count = rangeDown; count >= rangeUp; count--)
                {


                    sum += count;
                    //Console.WriteLine(sum);
                    //Console.WriteLine(kol);
                    kol++;

                }

            }

            result = sum / kol;

            Console.WriteLine("Ответ: " + result);


        }

        public static void task_two(int number)
        {

            int count;
            double sum;

            sum = 0.0;

            for (count = 1; count <= number; count++)
            {

                sum += (1 + 1 / (Math.Pow(number, 2)));

            }

            Console.WriteLine("Ответ: " + sum);

        }

        public static void VarikOne()
        {

            Console.Clear();
            Console.WriteLine("Введите команду...");
            Console.WriteLine("Первая задача <-");
            Console.WriteLine("Вторая задача.");
            Console.WriteLine("Настройки первой задачи.");
            Console.WriteLine("Настройки второй задачи.");
            Console.WriteLine("Выход.");


        }

        public static void VarikTwo()
        {

            Console.Clear();
            Console.WriteLine("Введите команду...");
            Console.WriteLine("Первая задача.");
            Console.WriteLine("Вторая задача <-");
            Console.WriteLine("Настройки первой задачи.");
            Console.WriteLine("Настройки второй задачи.");
            Console.WriteLine("Выход.");


        }

        public static void Varikthree()
        {

            Console.Clear();
            Console.WriteLine("Введите команду...");
            Console.WriteLine("Первая задача.");
            Console.WriteLine("Вторая задача.");
            Console.WriteLine("Настройки первой задачи <-");
            Console.WriteLine("Настройки второй задачи.");
            Console.WriteLine("Выход.");


        }
        public static void Varikfour()
        {

            Console.Clear();
            Console.WriteLine("Введите команду...");
            Console.WriteLine("Первая задача.");
            Console.WriteLine("Вторая задача.");
            Console.WriteLine("Настройки первой задачи.");
            Console.WriteLine("Настройки второй задачи <-");
            Console.WriteLine("Выход.");


        }

        public static void Varikfive()
        {

            Console.Clear();
            Console.WriteLine("Введите команду...");
            Console.WriteLine("Первая задача.");
            Console.WriteLine("Вторая задача.");
            Console.WriteLine("Настройки первой задачи.");
            Console.WriteLine("Настройки второй задачи.");
            Console.WriteLine("Выход <-");


        }

        static void Main(string[] args)
        {


            int n, count, rangeup, rangedown, setnum;


            count = 1;
            setnum = 1;
            rangedown = -34;
            rangeup = -161;

            ConsoleKeyInfo key;

            VarikOne();

            while ((count != 3) || (count != -1))
            {

                key = Console.ReadKey();

                if (key.Key == ConsoleKey.DownArrow)
                {

                    if (count < 5)
                    {


                        count++;
                        Console.WriteLine(count);


                    }

                    Console.SetCursorPosition(0, 4);

                }

                if (key.Key == ConsoleKey.UpArrow)
                {

                    if (count > 1)
                    {

                        //Console.SetCursorPosition(0, 4);
                        count--;
                        Console.WriteLine(count);

                    }

                    Console.SetCursorPosition(0, 4);

                }

                switch (count)
                {

                    case 1:
                        {

                            VarikOne();
                            break;

                        }

                    case 2:
                        {

                            VarikTwo();
                            break;

                        }

                    case 3:
                        {

                            Varikthree();
                            break;

                        }

                    case 4:
                        {

                            Varikfour();
                            break;

                        }

                    case 5:
                        {

                            Varikfive();
                            break;

                        }

                }

                if (key.Key == ConsoleKey.Enter)
                {

                    switch (count)
                    {

                        case 1:
                            {

                                Console.WriteLine();
                                task_one(rangedown, rangeup);
                                break;
                                //return;

                            }

                        case 2:
                            {

                                Console.WriteLine();

                                task_two(setnum);
                                break;
                                //return;

                            }

                        case 3:
                            {

                                Console.WriteLine("Введите от какого числа считать: ");

                                while (!(int.TryParse(Console.ReadLine(), out rangedown)))
                                {

                                    Console.WriteLine("Некорректно введенное число...");

                                }

                                Console.WriteLine("Введите до какого числа считать: ");

                                while (!(int.TryParse(Console.ReadLine(), out rangeup)))
                                {

                                    Console.WriteLine("Некорректно введенное число...");

                                }

                                Console.WriteLine("Настройка успешно завершена!");

                                break;

                            }

                        case 4:
                            {

                                Console.WriteLine("Введите до какого числа исполнять формулу: ");

                                while (!(int.TryParse(Console.ReadLine(), out setnum)))
                                {

                                    Console.WriteLine("Некорректно введенное число...");

                                }

                                Console.WriteLine("Настройка успешно завершена!");

                                break;

                            }

                        case 5:
                            {

                                count = -1;
                                Console.WriteLine();
                                Console.WriteLine("Пока!");
                                return;

                            }

                    }

                    Console.WriteLine("Для продолжения нажмите любую кнопку...");
                    Console.ReadKey();

                    count = 1;
                    VarikOne();

                }
            }
        }
    }
}
