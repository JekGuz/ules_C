using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ules_C
{
    internal class funktionide_Class_1_osa
    {
        public static float Kalkulaator(int arv1, int arv2)
        {
            float kalkulaator = 0;
            kalkulaator = arv1 * arv2;
            return kalkulaator;
        }
        public static string nadalapaeva(int a)
        {
            string tekst = string.Empty;
            switch (a)
            {
                case 1: tekst = "Esmaspäev"; break;
                case 2: tekst = "Teisipäev"; break;
                case 3: tekst = "Kolmapäev"; break;
                case 4: tekst = "Neljapäev"; break;
                case 5: tekst = "Reedel"; break;
                case 6: tekst = "Laupäev"; break;
                case 7: tekst = "Puhapäev"; break;

                default:
                    tekst = "Tundmatu";
                    break;
            }
            return tekst;
        }
        public static string juku(string nimi)
        {
            string vastu = string.Empty;
            if (nimi.ToLower() == "juku")
            {
                Console.WriteLine("Lähme kinno!");
                try
                {
                    Console.WriteLine("{0} \nKui vana sa oled?", nimi);
                    int vanus = int.Parse(Console.ReadLine());
                    if (vanus <= 0 || vanus > 100) // || - or, && - and
                    {
                        vastu = "Viga!";
                    }
                    else if (vanus > 0 && vanus <= 6)
                    {
                        vastu = "Tasuta";
                    }
                    else if (vanus <= 15)
                    {
                        vastu = "Lastepilet";
                    }
                    else if (vanus <= 65)
                    {
                        vastu = "Täispilet";
                    }
                    else if (vanus <= 100)
                    {
                        vastu = "Sooduspilet";
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            else
            {
                vastu = "Olen hõivatud!";
            }
            return vastu;
        }
        public static string nabrid(string nimi1, string nimi2)
        {
            Console.Write("Mis on esimene nimi? ");
            nimi1 = Console.ReadLine();
            Console.Write("Mi on teine nimi? ");
            nimi2 = Console.ReadLine();
            string vastus = "Nüüd me olime nabrid " + nimi1 + " ja " + nimi2;

            return vastus;

        }
        public static string remont(string vastus)
        {
            try
            {
                Console.Write("Kas soovime teha remont?\n(jah/ei) ");
                string vastu = Console.ReadLine();
                if (vastu == "jah")
                {
                    Console.Write("Misugune on seina pikkus: ");
                    a = float.Parse(Console.ReadLine());
                    Console.Write("Misugune on seina laius: ");

                    b = int.Parse(Console.ReadLine());
                    return a * b;
                }
                else if (vastu == "ei")
                {
                    Console.Write("Kena päeva!");

                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }

}
