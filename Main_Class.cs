using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ules_C
{
    internal class Main_Class
    {
        public static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Tere!");
            // I. osa Andmetyybid, IF, Case, Random, Almafunktsioonid
            /*
             Lisame siia kommentaari
             */
            int a = 0;
            string tekst = "Python to C#";
            char taht = 'P';
            double arv = 5.23456787541;
            float arv1 = 2;
            Console.Write("Mis on sinu nimi? ");
            tekst = Console.ReadLine();
            Console.WriteLine("Tere! \n" + tekst);
            Console.WriteLine("Tere! \n {0}", tekst);
            if (tekst.ToLower() == "juku")
            {
                Console.WriteLine("Lähme kinno!");
                try
                {
                    Console.WriteLine("{0} \nKui vana sa oled?", tekst);
                    int vanus = int.Parse(Console.ReadLine());
                    if (vanus <= 0 || vanus > 100) // || - or, && - and
                    {
                        Console.WriteLine("Viga!");
                    }
                    else if (vanus > 0 && vanus <= 6) 
                    {
                        Console.WriteLine("Tasura");
                        Console.BackgroundColor= ConsoleColor.Green;
                    }
                    else if (vanus <= 15)
                    {
                        Console.WriteLine("Lastepilet");
                        Console.BackgroundColor = ConsoleColor.Magenta;
                    }
                    else if (vanus <= 65)
                    {
                        Console.WriteLine("Täispilet");
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                    }
                    else if (vanus <= 100)
                    {
                        Console.WriteLine("Sooduspilet");
                        Console.BackgroundColor = ConsoleColor.White;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            else
            {
                Console.WriteLine("Olen hõivatud!");
            }


            Console.Write("Arv 2: ");
            int arv2 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Arvude {0} ja {1} korrutis võrdub {2}", arv1, arv2, arv1 + arv2);
            arv1 = funktionide_Class.Kalkulaator(a, arv2);
            Console.WriteLine(arv1);

            Console.WriteLine("Switch'i kasutamine");
            Random rnd = new Random();
            a = rnd.Next(1, 7);
            Console.WriteLine(a);
            switch (a)
            {
                case 1: tekst = "Esmaspäev";break;
                case 2: tekst = "Teisipäev";break;
                case 3: tekst = "Kolmapäev";break;
                case 4: tekst = "Neljapäev";break;
                case 5: tekst = "Reedel";break;
                case 6: tekst = "Laupäev";break;
                case 7: tekst = "Puhapäev";break;

                default:
                    tekst = "Tundmatu";
                    break;
            }
            Console.WriteLine(tekst);

            Console.ReadKey();
        }
    }
}
