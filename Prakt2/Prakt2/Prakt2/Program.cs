using System;

namespace Prakt2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, t, e;

            Console.WriteLine("Введите a...");

            while (!int.TryParse(Console.ReadLine(), out a))
            {

                Console.WriteLine("Введено не число. Повторите попытку.");

            }

            Console.WriteLine("Введите b...");

            while (!int.TryParse(Console.ReadLine(), out b))
            {

                Console.WriteLine("Введено не число. Повторите попытку.");

            }

            if (a > b)
            {

                Console.WriteLine("Введите t...");

                while (!int.TryParse(Console.ReadLine(), out t))
                {

                    Console.WriteLine("Введено не число. Повторите попытку.");

                }

                Console.WriteLine(2 / 3 * Math.Pow(t, 3) + 3 * b * t - Math.Sin(t));

            }

            if (a < b)
            {

                Console.WriteLine("Введите e...");

                while (!int.TryParse(Console.ReadLine(), out e))
                {

                    Console.WriteLine("Введено не число. Повторите попытку.");

                }

                Console.WriteLine("Введите t...");

                while (!int.TryParse(Console.ReadLine(), out t))
                {

                    Console.WriteLine("Введено не число. Повторите попытку.");

                }

                Console.WriteLine(Math.Pow(e, a + b) + Math.Pow(10, -3) * Math.Pow(t, 2));

            }

            if (a == b)
            {

                Console.WriteLine("Введите t...");

                while (!int.TryParse(Console.ReadLine(), out t))
                {

                    Console.WriteLine("Введено не число. Повторите попытку.");

                }

                Console.WriteLine("Введите a...");

                while (!int.TryParse(Console.ReadLine(), out a))
                {

                    Console.WriteLine("Введено не число. Повторите попытку.");

                }

                Console.WriteLine(a * Math.Sin(Math.Pow(t, 2) + b));

            }

            Console.ReadKey();

        }
    }
}
