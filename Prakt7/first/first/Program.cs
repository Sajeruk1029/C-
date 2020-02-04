using System;
using System.IO;

namespace first
{

    public struct Root_BD
    {

        Root_BD{


        public string[] Data;//21
        public string Familiya, Imy, Otchestvo, Seria_pasp, Numb_pasp, Kol_obrazovaniy, Doljnost, Oklad, Stavka, Data_rojdeniya, INN, Snils, Mesto_jitelstva_registraciya, Mesto_jitelstva_po_factu, Nomer_telephona, Nomer_domashniy, Nomer_trudovogo_dogovora, Electronaya_pochta, Pol, Kol_deti;


    }

    public class Class1
    {

        public static void Main()
        {

            //------------------------------------------------------------------
            int count, count2, count3 = 1, rezerv, rezerv_znachimiy = 20, dd, mm, yy;
            string name;
            ConsoleKeyInfo key;
            StreamWriter sw;
            StreamReader sr;
            //------------------------------------------------------------------

            //------------------------------------------------------------------
            string[,] matrix_obrazovaniy;
            string[,] matrix_deti;
            //------------------------------------------------------------------

            //------------------------------------------------------------------
            Root_BD data_sotrudnik = new Root_BD();
            //------------------------------------------------------------------

            //------------------------------------------------------------------
            if (!Directory.Exists("C:/Root_BD/"))
            {
                Directory.CreateDirectory("C:/Root_BD/");
            }
            //------------------------------------------------------------------
            if (!File.Exists("C:/Root_BD/BD.txt"))
            {
                File.Create("C:/Root_BD/BD.txt").Close();
            }
            //------------------------------------------------------------------
            Console.WriteLine("Введите фамилию...");
            data_sotrudnik.Familiya = Console.ReadLine();
            while(data_sotrudnik.Familiya == "")
            {
                Console.WriteLine("Введите фамилию...");
                data_sotrudnik.Familiya = Console.ReadLine();
            }
            Console.WriteLine("Введите имя...");
            data_sotrudnik.Imy = Console.ReadLine();
            while (data_sotrudnik.Imy == "")
            {
                Console.WriteLine("Введите имя...");
                data_sotrudnik.Imy = Console.ReadLine();
            }
            Console.WriteLine("Введите отчество...");
            data_sotrudnik.Otchestvo = Console.ReadLine();
            while (data_sotrudnik.Otchestvo == "")
            {
                Console.WriteLine("Введите отчество...");
                data_sotrudnik.Otchestvo = Console.ReadLine();
            }
            //------------------------------------------------------------------

            Console.Clear();

            //------------------------------------------------------------------
            while (true)
            {
                Console.WriteLine("Введите серию паспорта...");
                data_sotrudnik.Seria_pasp = Console.ReadLine();

                if (data_sotrudnik.Seria_pasp.Length != 4)
                {
                    Console.WriteLine("Ошибка! В серийном номере паспорта должно быть 4 цифры!");
                    continue;
                }
                try
                {
                    for (count = 0; count < 4; count++)
                    {
                        Convert.ToInt32(data_sotrudnik.Seria_pasp[count].ToString());
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка! В серийном номере паспорта паспорта не должно быть символов кроме цифр!");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.WriteLine("Введите номер паспорта...");
                data_sotrudnik.Numb_pasp = Console.ReadLine();

                if (data_sotrudnik.Numb_pasp.Length != 6)
                {
                    Console.WriteLine("Ошибка! В номере паспорта должно быть 6 цифры!");
                    continue;
                }
                try
                {
                    for (count = 0; count < 6; count++)
                    {
                        Convert.ToInt32(data_sotrudnik.Numb_pasp[count].ToString());
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка! В номере паспорта не должно быть символов кроме цифр!");
                    continue;
                }
                break;
            }
            //------------------------------------------------------------------

            Console.Clear();

            //------------------------------------------------------------------

            Console.WriteLine("Введите количество образований...");

            while (!int.TryParse(Console.ReadLine(), out rezerv) || (rezerv < 0))
            {
                Console.WriteLine("Ошибка! Количество образований не должно состоять из символов кроме цифр!");
            }

            data_sotrudnik.Kol_obrazovaniy = rezerv.ToString();

            matrix_obrazovaniy = new string[rezerv, 3];
            rezerv_znachimiy += matrix_obrazovaniy.Length;

            for (count = 0; count < rezerv; count++)
            {

                for (count2 = 0; count2 < 2; count2++)
                {

                    if (count2 == 0)
                    {
                        Console.WriteLine("Введите " + count3 + " образование...");
                        matrix_obrazovaniy[count, count2] = Console.ReadLine();
                    }

                    if (count2 == 1)
                    {

                        Console.WriteLine("Было ли закончено " + count3 + " образование(д/н)...");
                        key = Console.ReadKey(true);

                        while ((key.Key != ConsoleKey.L) && (key.Key != ConsoleKey.Y))
                        {
                            Console.WriteLine("Было ли закончено " + count3 + " образование(д/н)...");
                            key = Console.ReadKey(true);
                        }

                        if (key.Key == ConsoleKey.L)
                        {

                            matrix_obrazovaniy[count, 1] = "Закончено";
                            Console.WriteLine("Введите день окончания " + count3 + " образования...");

                            while (!int.TryParse(Console.ReadLine(), out dd) || ((dd < 1) || (dd > 32)))
                            {
                                Console.WriteLine("Не корректно введен день окончания!");
                            }

                            Console.WriteLine("Введите месяц окончания " + count3 + " образования...");

                            while (!int.TryParse(Console.ReadLine(), out mm) || ((mm < 1) || (mm > 12)))
                            {
                                Console.WriteLine("Не корректно введен месяц окончания!");
                            }

                            Console.WriteLine("Введите год окончания " + count3 + " образования...");

                            while (!int.TryParse(Console.ReadLine(), out yy) || ((yy < 1) || (yy > 100000)))
                            {
                                Console.WriteLine("Не корректно введен год окончания!");
                            }

                            matrix_obrazovaniy[count, 2] = dd.ToString() + '.' + mm.ToString() + '.' + yy.ToString();
                            count3++;
                        }

                        if (key.Key == ConsoleKey.Y)
                        {

                            matrix_obrazovaniy[count, 1] = "Не закончено";
                            matrix_obrazovaniy[count, 2] = "Нет";
                            count3++;

                        }
                    }

                }

            }
            //------------------------------------------------------------------
            Console.Clear();
            //------------------------------------------------------------------

            Console.WriteLine("Введите должность...");
            data_sotrudnik.Doljnost = Console.ReadLine();

            Console.WriteLine("Введите оклад...");
            while (!int.TryParse(Console.ReadLine(), out rezerv))
            {
                Console.WriteLine("Оклад должен быть числом!");
            }

            data_sotrudnik.Oklad = rezerv.ToString();

            Console.WriteLine("Введите ставку...");
            while (!int.TryParse(Console.ReadLine(), out count) || (count <= rezerv))
            {
                Console.WriteLine("Ставка должен быть числом и при том больше оклада!");
            }

            data_sotrudnik.Stavka = count.ToString();

            //------------------------------------------------------------------
            Console.Clear();
            //------------------------------------------------------------------

            Console.WriteLine("Введите день рождения...");

            while (!int.TryParse(Console.ReadLine(), out dd) || ((dd < 1) || (dd > 32)))
            {
                Console.WriteLine("Не корректно введен день рождения!");
            }

            Console.WriteLine("Введите месяц рождения...");

            while (!int.TryParse(Console.ReadLine(), out mm) || ((mm < 1) || (mm > 12)))
            {
                Console.WriteLine("Не корректно введен месяц рождения!");
            }

            Console.WriteLine("Введите год рождения...");

            while (!int.TryParse(Console.ReadLine(), out yy) && ((yy < 1) || (yy > 100000)))
            {
                Console.WriteLine("Не корректно введен год рождения!");
            }

            data_sotrudnik.Data_rojdeniya = dd.ToString() + '.' + mm.ToString() + '.' + yy.ToString();

            //------------------------------------------------------------------
            Console.Clear();
            //------------------------------------------------------------------

            while (true)
            {
                Console.WriteLine("Введите инн...");
                data_sotrudnik.INN = Console.ReadLine();

                if (data_sotrudnik.INN.Length != 12)
                {
                    Console.WriteLine("Ошибка! В инн должно быть 12 цифр!");
                    continue;
                }
                try
                {
                    for (count = 0; count < 12; count++)
                    {
                        Convert.ToInt32(data_sotrudnik.INN[count].ToString());
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка! В инн не должно быть символов кроме цифр!");
                    continue;
                }
                break;
            }

            //------------------------------------------------------------------
            Console.Clear();
            //------------------------------------------------------------------

            while (true)
            {
                Console.WriteLine("Введите снилс...");
                data_sotrudnik.Snils = Console.ReadLine();

                if (data_sotrudnik.Snils.Length != 11)
                {
                    Console.WriteLine("Ошибка! В снилс должно быть 11 цифр!");
                    continue;
                }
                try
                {
                    for (count = 0; count < 11; count++)
                    {
                        Convert.ToInt32(data_sotrudnik.Snils[count].ToString());
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка! В снилс не должно быть символов кроме цифр!");
                    continue;
                }
                break;
            }

            //------------------------------------------------------------------
            Console.Clear();
            //------------------------------------------------------------------

            Console.WriteLine("Введите местожительства регистрацию...");
            data_sotrudnik.Mesto_jitelstva_registraciya = Console.ReadLine();

            Console.WriteLine("Введите местожительства по факту...");
            data_sotrudnik.Mesto_jitelstva_po_factu = Console.ReadLine();

            //------------------------------------------------------------------
            Console.Clear();
            //------------------------------------------------------------------


            while (true)
            {
                Console.WriteLine("Введите номер телефона...");
                data_sotrudnik.Nomer_telephona = Console.ReadLine();

                    if (data_sotrudnik.Nomer_telephona == "")
                    {

                        data_sotrudnik.Nomer_telephona = "Нет.";
                        break;

                    }

                if (data_sotrudnik.Nomer_telephona.Length != 10)
                {
                    Console.WriteLine("Ошибка! В номере должно быть 10 цифр!");
                    continue;
                }
                try
                {
                    for (count = 0; count < 10; count++)
                    {
                        Convert.ToInt32(data_sotrudnik.Nomer_telephona[count].ToString());
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка! В снилс не должно быть символов кроме цифр!");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.WriteLine("Введите номер домашний...");
                data_sotrudnik.Nomer_domashniy = Console.ReadLine();

                if(data_sotrudnik.Nomer_domashniy == "")
                {

                    data_sotrudnik.Nomer_domashniy = "Нет.";
                    break;

                }

                if (data_sotrudnik.Nomer_domashniy.Length != 10)
                {
                    Console.WriteLine("Ошибка! В номере должно быть 10 цифр!");
                    continue;
                }
                try
                {
                    for (count = 0; count < 10; count++)
                    {
                        Convert.ToInt32(data_sotrudnik.Nomer_domashniy[count].ToString());
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка! В снилс не должно быть символов кроме цифр!");
                    continue;
                }
                break;
            }

            //------------------------------------------------------------------
            Console.Clear();
            //------------------------------------------------------------------


            Console.WriteLine("Введите номер трудового договора...");
            data_sotrudnik.Nomer_trudovogo_dogovora = Console.ReadLine();

            while (data_sotrudnik.Nomer_trudovogo_dogovora == "")
            {
                Console.WriteLine("Номер трудового договора не должен быть пустым.");
                data_sotrudnik.Nomer_trudovogo_dogovora = Console.ReadLine();
            }

            //------------------------------------------------------------------
            Console.Clear();
            //------------------------------------------------------------------

            count2 = 0;
            count3 = 0;

            while (true)
            {
                Console.WriteLine("Введите адрес электронной почты...");

                data_sotrudnik.Electronaya_pochta = Console.ReadLine();

                for(count = 0; count < data_sotrudnik.Electronaya_pochta.Length; count++)
                {
                    if(data_sotrudnik.Electronaya_pochta[count] == '@')
                    {
                        count2++;
                    }

                    if (data_sotrudnik.Electronaya_pochta[count] == '.')
                    {
                        count3++;
                    }

                }

                if (count2 != 1)
                {
                    Console.WriteLine("Электронная почта введена некорректна.");
                    continue;
                }

                if (count3 != 1)
                {   
                    Console.WriteLine("Электронная почта введена некорректна.");
                    continue;
                }
                /*
                if (!data_sotrudnik.Electronaya_pochta.Contains("@"))
                {
                    Console.WriteLine("Электронная почта должна содержать один @");
                    continue;
                }

                if (data_sotrudnik.Electronaya_pochta.Substring(data_sotrudnik.Electronaya_pochta.IndexOf("@"), 1) == "@");
                {
                    Console.WriteLine("Электронная почта должна содержать один @");
                    continue;
                }
                */
                if (!data_sotrudnik.Electronaya_pochta.Contains(".ru"))
                {
                    Console.WriteLine("Электронная почта должна содержать домен");
                    continue;
                }
                break;
            }

            //------------------------------------------------------------------
            Console.Clear();
            //------------------------------------------------------------------

            Console.WriteLine("Выберите пол(М/Ж)...");
            key = Console.ReadKey(true);


            while ((key.Key != ConsoleKey.V) && (key.Key != ConsoleKey.Oem1))
            {
                Console.WriteLine("Выберите пол(М/Ж)...");
                key = Console.ReadKey(true);

            }


            if (key.Key == ConsoleKey.V)
            {
                data_sotrudnik.Pol = "Мужчина";
            }

            if (key.Key == ConsoleKey.Oem1)
            {
                data_sotrudnik.Pol = "Женщина";
            }

            //------------------------------------------------------------------
            Console.Clear();
            //------------------------------------------------------------------

            Console.WriteLine("Введите количество детей...");

            while (!int.TryParse(Console.ReadLine(), out rezerv))
            {
                Console.WriteLine("В количестве детей не может быть букв...");
            }

            count3 = 1;
            data_sotrudnik.Kol_deti = rezerv.ToString();

            matrix_deti = new string[rezerv, 2];
            rezerv_znachimiy += matrix_deti.Length;

            for (count = 0; count < rezerv; count++)
            {

                for (count2 = 0; count2 < 2; count2++)
                {

                    switch (count2)
                    {

                        case 0:
                            {
                                Console.WriteLine("Введите имя ребенка " + count3);
                                matrix_deti[count, 0] = Console.ReadLine();
                                break;
                            }

                        case 1:
                            {
                                Console.WriteLine("Введите возраст ребенка " + count3 + " ...");
                                while (!int.TryParse(Console.ReadLine(), out dd))
                                {
                                    Console.WriteLine("Возраст введен некорректно!");
                                }
                                matrix_deti[count, 1] = dd.ToString();
                                break;
                            }
                    }

                }

            count3++;

            }

            //------------------------------------------------------------------
            Console.Clear();
            //------------------------------------------------------------------


            data_sotrudnik.Data = new string[rezerv_znachimiy];
            count = 6;

            data_sotrudnik.Data[0] = data_sotrudnik.Familiya;
            data_sotrudnik.Data[1] = data_sotrudnik.Imy;
            data_sotrudnik.Data[2] = data_sotrudnik.Otchestvo;
            data_sotrudnik.Data[3] = data_sotrudnik.Seria_pasp;
            data_sotrudnik.Data[4] = data_sotrudnik.Numb_pasp;
            data_sotrudnik.Data[5] = data_sotrudnik.Kol_obrazovaniy;

                for (count2 = 0; count2 < matrix_obrazovaniy.Length / 3; count2++)
                {
                    for (count3 = 0; count3 < 3; count3++)
                    {
                        data_sotrudnik.Data[count] = matrix_obrazovaniy[count2, count3];
                        count++;
                    }
                }

                data_sotrudnik.Data[6 + matrix_obrazovaniy.Length] = data_sotrudnik.Doljnost;
                data_sotrudnik.Data[6 + matrix_obrazovaniy.Length + 1] = data_sotrudnik.Oklad;
                data_sotrudnik.Data[6 + matrix_obrazovaniy.Length + 2] = data_sotrudnik.Stavka;
                data_sotrudnik.Data[6 + matrix_obrazovaniy.Length + 3] = data_sotrudnik.Data_rojdeniya;
                data_sotrudnik.Data[6 + matrix_obrazovaniy.Length + 4] = data_sotrudnik.INN;
                data_sotrudnik.Data[6 + matrix_obrazovaniy.Length + 5] = data_sotrudnik.Snils;
                data_sotrudnik.Data[6 + matrix_obrazovaniy.Length + 6] = data_sotrudnik.Mesto_jitelstva_registraciya;
                data_sotrudnik.Data[6 + matrix_obrazovaniy.Length + 7] = data_sotrudnik.Mesto_jitelstva_po_factu;
                data_sotrudnik.Data[6 + matrix_obrazovaniy.Length + 8] = data_sotrudnik.Nomer_telephona;
                data_sotrudnik.Data[6 + matrix_obrazovaniy.Length + 9] = data_sotrudnik.Nomer_domashniy;
                data_sotrudnik.Data[6 + matrix_obrazovaniy.Length + 10] = data_sotrudnik.Nomer_trudovogo_dogovora;
                data_sotrudnik.Data[6 + matrix_obrazovaniy.Length + 11] = data_sotrudnik.Electronaya_pochta;
                data_sotrudnik.Data[6 + matrix_obrazovaniy.Length + 12] = data_sotrudnik.Pol;
                data_sotrudnik.Data[6 + matrix_obrazovaniy.Length + 13] = data_sotrudnik.Kol_deti;

                if (matrix_deti.Length != 0)
                {
                    count = 14;

                    for (count2 = 0; count2 < matrix_deti.Length / 2; count2++)
                    {

                        for (count3 = 0; count3 < 2; count3++)
                        {

                            data_sotrudnik.Data[6 + matrix_obrazovaniy.Length + count] = matrix_deti[count2, count3];
                            count++;


                }

                }

            }

            //-----------------------------------------------------------------
            sw = new StreamWriter("C:/Root_BD/BD.txt", true);
            sw.AutoFlush = true;

            for(count = 0; count < data_sotrudnik.Data.Length; count++)
            {
                sw.WriteLine(data_sotrudnik.Data[count]);
                sw.WriteLine();
            }

            sw.Close();
            //------------------------------------------------------------------
            sr = new StreamReader("C:/Root_BD/BD.txt");

            Console.WriteLine(sr.ReadToEnd());

            sr.Close();
            //------------------------------------------------------------------
        }



    }
    }
