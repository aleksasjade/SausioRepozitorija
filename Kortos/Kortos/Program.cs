using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kortos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KortuKalade kalade = new KortuKalade();

            foreach (Korta korta in kalade.KortuSarasas)
            {
                Console.WriteLine($"{korta.Pavadinimas} {korta.Zenklas}");
            }

            Console.WriteLine($"\nViso kortu: {kalade.KortuSarasas.Count()}");
            Console.ReadLine();

        }
    }
}
