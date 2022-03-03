using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_13
{
    internal class SukurtaKlase : IPrintData
    {
        public string Tekstas;
        public int Skaicius;
        public List<int> Sarasiukas;

        public SukurtaKlase(string tekstas, int skaicius, List<int> sarasiukas)
        {
            Tekstas = tekstas;
            Skaicius = skaicius;
            Sarasiukas = sarasiukas;
        }

        public void PrintData()
        {
            Console.WriteLine(" Klase:");
            Console.WriteLine($" Tekstas: {Tekstas}");
            Console.WriteLine($" Skaicius: {Skaicius}");
            Console.Write(" Sarasiukas: ");
            foreach (var item in Sarasiukas)
            {
                Console.Write($"{item} ");
                
            }
            Console.WriteLine();
        }
    }
}
