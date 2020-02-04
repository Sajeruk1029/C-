
using System;

namespace Prakt2_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int numb;

            numb = 0;

            Console.WriteLine("Введите число 1-7...");

            if (!int.TryParse(Console.ReadLine(), out numb))
            {

                Console.WriteLine("Не число.");

            }
            else
            {

                switch (numb)
                {

                    case 1:
                        {

                            Console.WriteLine("Понедельник.");
                            break;

                        }

                    case 2:
                        {

                            Console.WriteLine("Вторник.");
                            break;

                        }

                    case 3:
                        {

                            Console.WriteLine("Среда.");
                            break;

                        }

                    case 4:
                        {

                            Console.WriteLine("Четверг.");
                            break;

                        }

                    case 5:
                        {

                            Console.WriteLine("Пятница.");
                            break;

                        }

                    case 6:
                        {

                            Console.WriteLine("Суббота.");
                            break;

                        }

                    case 7:
                        {

                            Console.WriteLine("Воскресенье.");
                            break;

                        }

                    default:
                        {

                            Console.WriteLine("Нет такого дня недели.");
                            break;

                        }


                }

            }
            Console.ReadKey();

        }



    }

}
