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
            //----------------------------C# Kordused ja massiivid. Teoria+Ülesanded---------------------
            Console.WriteLine("-------Mang---------");
            funktionide_Class_2_osa.KuniMärksõnani("Eleavant", "Osta elevant ära!");


            //////2 OSA kordused, Massivid, Listid, Klassid
            //////List<string> sonad = funktionide_Class_2_osa.s6nad();
            //////foreach (var item in sonad)
            //////{
            //////    Console.WriteLine(item);
            //////}

            //////Isik isik1 = new Isik("Juku", 18, "123456781234", "Tallinn", Sugu.Mees);
            //////isik1.PrindiInfo();
            //////Isik isik2 = new Isik();
            //////isik2.Nimi = "Mari";
            //////isik2.Aadress = "Tartu";
            //////isik2.Isikukood = "56874545454";
            //////isik2.Sugu = Sugu.Naine;
            //////isik2.PrindiInfo();




            //////FOR i
            //////int i = 0;
            //////Massiv
            //////Console.WriteLine("-------FOR-UP-Massiv------");
            //////Isik[] isikud = new Isik[10];
            //////string[] nimid = new string[10] { "Juku", "Mati", "Kati", "Peeter", "Maria", "Liina", "Karina", "Mary", "Ravil", "Iryna" };
            //////string[] aadressid = new string[10] { "Tallinn", "Tartu", "Parnu", "Maardu", "Viljandi", "Voru", "Keila", "Rjapina", "Narva", "Rakvere" };
            //////Isik[] isikud = funktionide_Class_2_osa.Isikud(nimid.Length, nimid, aadressid);

            //////for (i = 0; i < 10; i++)
            //////{ isikud[i].PrindiInfo(); }

            //////Console.WriteLine("-------FOR-DOWN-List-----");
            //////List<Isik> isikud2 = new List<Isik>(); // list
            //////for (int j = i - 1; j > -1; j--)  // уменьшаем
            //////{
            //////    Console.WriteLine(j);
            //////    Isik isik = new Isik
            //////    {
            //////        Nimi = nimid[j],
            //////        Vanus = 50,
            //////        Isikukood = "11111111111",
            //////        Aadress = aadressid[j]
            //////    };
            //////    isikud2.Add(isik);
            //////}
            //////foreach (Isik isik in isikud2) // перебираем список var - когда не надо определять тип данных Isik - перебираем наш список
            //////{
            //////    isik.PrindiInfo();
            //////}

            //////WHILE(true)
            //////Console.WriteLine("------WHILE-(i>0)---------");
            //////while (i > 0)
            //////{
            //////    Console.WriteLine(i);
            //////    i--;
            //////}
            //////Console.WriteLine("------DO---------");
            //////ConsoleKeyInfo key = new ConsoleKeyInfo();
            //////do
            //////{
            //////    Console.WriteLine("Vajuta Backspace");
            //////    key = Console.ReadKey();
            //////}
            //////while (key.Key != ConsoleKey.Backspace);






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
