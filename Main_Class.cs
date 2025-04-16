using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ules_C
{
    internal class Main_Class
    {
        public static void Main(string[] args)
        {
            // 2 OSA kordused, Massivid, Listid, Klassid
            // FOR i
            Console.WriteLine("------FOR-UP------");
            int i = 0;
            for (i = 0; i < 10; i++) // увеличиваем
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-------FOR-DOWN------");

            for (int j = i; j > 0; j--)  // уменьшаем
            {
                Console.WriteLine(j);
            }
            // WHILE (true)
            Console.WriteLine("------WHILE-(i>0)---------");
            while (i > 0)
            {
                Console.WriteLine(i);
                i --;
            }
            Console.WriteLine("------DO---------");
            Console.WriteLine("backspace");
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            do 
            {
                Console.WriteLine("Vajuta Backspace");
                key = Console.ReadKey();
            }
            while (key.Key != ConsoleKey.Backspace);

            // 3 OSA Faillid, Andmetüüdb, IF, CASE, RANDOM, Alamfunktioonid



            /* 1 OSA
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Tere!");
            // I. osa Andmetyybid, IF, Case, Random, Almafunktsioonid
            /*
             Lisame siia kommentaari
            
            int a = 0;
            string tekst = string.Empty;
            string tekst2 = string.Empty;
            char taht = 'P';
            double arv = 5.23456787541;
            float arv1 = 2;
            float arv5 = 1;
            string vastus = string.Empty;
            float vastus1 = 1;

            // remont
            Console.WriteLine("Otsustame renoveerimise üle!");
            vastus1 = funktionide_Class_1_osa.ristkulik(arv1, arv5);
            Console.WriteLine(vastus1);

            // Küsi kahe inimese nimed ning teata, et nad on täna pinginaabrid
            Console.WriteLine("Tere tulemas!");
            vastus = funktionide_Class_1_osa.nabrid(tekst, tekst2);
            Console.WriteLine(vastus);

            // juku
            Console.Write("Mis on sinu nimi? ");
            tekst = Console.ReadLine();
            Console.WriteLine("Tere! \n" + tekst);
            vastus = funktionide_Class_1_osa.juku(tekst); 
            Console.WriteLine(vastus);

            // kalkulatir
            Console.Write("Arv 2: ");
            int arv2 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Arvude {0} ja {1} korrutis võrdub {2}", arv1, arv2, arv1 + arv2);
            arv1 = funktionide_Class_1_osa.Kalkulaator(a, arv2);
            Console.WriteLine(arv1);

            // nadalapaevad
            Console.WriteLine("Switch'i kasutamine");
            Random rnd = new Random();
            a = rnd.Next(1, 7);
            Console.WriteLine(a);
            tekst = funktionide_Class_1_osa.nadalapaeva(a);
            Console.WriteLine(tekst);

            Console.ReadKey();
             */
        }
    }
}
