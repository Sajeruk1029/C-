using System;

namespace ConsoleApp4
{

    class Cake
    {

        private int kol_sloi = 0, cena = 0, koef = 0, razm, glazure, pudra, djem;
        private bool krug, treugolnik, kvadrat;

        public void set_form(int forma)
        {

            switch (forma)
            {

                case 0:
                    {//K'tun is a GOD. Are you LIssen he's songs?

                        krug = true;
                        koef = 2;
                        break;

                    }

                case 1:
                    {

                        treugolnik = true;
                        koef = 4;
                        break;

                    }

                case 2:
                    {

                        kvadrat = true;
                        koef = 6;
                        break;

                    }

            }

        }

        public void set_razmer(int diametr)
        {

            razm = diametr;

            if (diametr == 20)
            {

                koef += 2;

            }

            if (diametr == 30)
            {

                koef += 3;

            }

            if (diametr == 40)
            {

                koef += 4;

            }

        }

        public void set_kol_sloi(int kol)
        {

            kol_sloi = kol;


        }

        public void set_type_sloy(int glazere_ok, int pudra_ok, int djem_ok)
        {

            glazure = glazere_ok;
            pudra = pudra_ok;
            djem = djem_ok;

            if (glazure == 1)
            {
                koef += 5;

            }

            if (pudra == 1)
            {

                koef += 10;

            }

            if (djem == 1)
            {

                koef += 15;

            }

        }

        public void podscet()
        {

            cena += kol_sloi * koef;

        }

        public int get_cena()
        {

            return cena;

        }

    }
    class Program
    {
        static int pos = 0, etapi = 1;
        public void choose()
        {

            ConsoleKeyInfo key;

            while (true)
            {

                key = Console.ReadKey();

                if ((key.Key == ConsoleKey.UpArrow) && (pos != 0))
                {

                    pos--;

                }

                if ((key.Key == ConsoleKey.DownArrow) && (pos != 3))
                {

                    pos++;

                }

                if (key.Key == ConsoleKey.Enter)
                {

                    switch (pos)
                    {

                        case 0:
                            {


                                break;

                            }

                    }

                }

            }

        }

        public static void set_forma()
        {

            Console.Clear();

            Console.WriteLine("Выберите форму коржей...");
            Console.WriteLine("1.Круг(2р за корж)");
            Console.WriteLine("2.Треугольник(4р за корж)");
            Console.WriteLine("3.Квадрат(6р за корж)");

        }

        public static void set_razmer()
        {

            Console.Clear();

            Console.WriteLine("Выберите размер коржа...");
            Console.WriteLine("1.20 см(2р за корж)");
            Console.WriteLine("2.30 см(3р за корж)");
            Console.WriteLine("3.40 см(4р за корж)");

        }

        public static void set_korg()
        {

            Console.Clear();

            Console.WriteLine("Введите количество коржей...");


        }

        public static void set_nachinka()
        {

            Console.Clear();

            Console.WriteLine("Выберите начинку коржей...");
            Console.WriteLine("1.Глазурь(5р за корж)");
            Console.WriteLine("2.Пудра(10р за корж)");
            Console.WriteLine("3.Джем(15р за корж)");
            Console.WriteLine("1.2.3.Джем(15р за корж)");

        }

        static void Main(string[] args)
        {
           
            Console.CancelKeyPress += delegate (object sender, ConsoleCancelEventArgs e) {
                e.Cancel = true;
            };

            int choose, choose2, choose3;

            Cake cake = new Cake();

            set_forma();

            while ((!int.TryParse(Console.ReadLine(), out choose)) || !(choose < 4) || !(choose > 0)) { Console.WriteLine("Введенное значение некорректно."); }
            cake.set_form(choose);

            set_razmer();

            while ((!int.TryParse(Console.ReadLine(), out choose)) || !(choose < 4) || !(choose > 0)) { Console.WriteLine("Введенное значение некорректно."); }
            cake.set_razmer(choose);

            set_korg();

            while ((!int.TryParse(Console.ReadLine(), out choose)) || !(choose > 0)) { Console.WriteLine("Введенное значение некорректно."); }
            cake.set_kol_sloi(choose);

            set_nachinka();

            while ((!int.TryParse(Console.ReadLine(), out choose)) || !(choose > -1) || !(choose < 2)) { Console.WriteLine("Введенное значение некорректно."); }

            while ((!int.TryParse(Console.ReadLine(), out choose2)) || !(choose2 > -1) || !(choose2 < 2)) { Console.WriteLine("Введенное значение некорректно."); }

            while ((!int.TryParse(Console.ReadLine(), out choose3)) || !(choose3 > -1) || !(choose3 < 2)) { Console.WriteLine("Введенное значение некорректно."); }

            cake.set_type_sloy(choose, choose2, choose3);

            cake.podscet();

            Console.WriteLine("Стоймость: " + cake.get_cena());

        }
    }
}
