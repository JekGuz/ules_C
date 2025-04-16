using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ules_C
    {
    internal enum Sugu
    {
        Mees,
        Naine
    }

    internal class Isik
    {
        public string Nimi { get; set; }
        public int Vanus { get; set; } = 18;
        public string Isikukood { get; set; }
        public string Aadress { get; set; }
        public Sugu Sugu { get; set; } = Sugu.Mees;
        public Isik(string nimi, int vanus, string isikukood, string aadress, Sugu sugu) // Sugu sugu
        {
            Nimi = nimi;
            Vanus = vanus;
            Isikukood = isikukood;
            Aadress = aadress;
        }
        public Isik()
        {
        }
         public Isik(string nimi)
        {
            Nimi = nimi;
        }
        

        public void PrindiInfo()
        {
            Console.WriteLine($" Nimi: {Nimi}, Vanus: {Vanus}, Isikukood: {Isikukood}, Aardess: {Aadress}, Sugu: {Sugu}");
        }
    }

}
