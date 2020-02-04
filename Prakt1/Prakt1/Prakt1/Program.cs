using System;

namespace Prakt1
{
    class Program
    {
        static void Main(string[] args)
        {

            //(2*c-d/23)/(ln(1-a/4))
            int a, b, c;

            if(Environment.GetCommandLineArgs().Length < 4)
            {
                Console.WriteLine("Недостаточно аргументов.");
                return;
            }

            a = Convert.ToInt32(Environment.GetCommandLineArgs()[1]);
            b = Convert.ToInt32(Environment.GetCommandLineArgs()[2]);
            c = Convert.ToInt32(Environment.GetCommandLineArgs()[3]);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.WriteLine((2 * a - b / 23) / (Math.Log10(1 - c)));

            Console.ReadKey();

        }
    }
}
