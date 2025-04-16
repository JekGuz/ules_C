using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ules_C
{
    internal class funktionide_Class_2_osa
    {
        public static List<string> KuniMärksõnani(string marksona, string fraas)
        {
            List<string> sisestused = new List<string>();
            string sisend;
            marksona = "fraas";
            while (true)
            {
                Console.WriteLine("fraas");
                sisend = Console.ReadLine();

                if (sisend == marksona)
                {
                    break;
                }
                else
                {
                    sisestused.Add(Console.ReadLine());
                }
            }

            Console.WriteLine("\nKõik sisendatud andmed:");
            foreach (string vastus in sisestused)
            {
                Console.WriteLine(vastus);
            }
            return sisestused;
        }
    }


        public static List<string> s6nad()
        {
            List<string> sonad = new List<string>();
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("Nimi: ");
                sonad.Add(Console.ReadLine());
            }
            return sonad;
        }
        public static Isik[] Isikud(int k, string[] nimed, string[] aadressid)
        {

            Isik[] isikud = new Isik[k];

            for (i = 0; i < k; i++) // увеличиваем
            {
                Console.WriteLine(i);
                //Masiiv
                //isikud[i] = new Isik
                Console.Write("Isikukood: ");
                isikud[i] = new Isik
                {
                    Nimi = nimid[i],
                    Vanus = 50,
                    Isikukood = Console.ReadLine(),
                    Aadress = aadressid[i],
                };
            }
            return isikud;
        }

    }
}