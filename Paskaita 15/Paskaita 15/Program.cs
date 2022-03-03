using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_15
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        private void UZDUOTIS1()
        {
            Console.Write("Iveskite savo amziu: ");
            int amzius = Convert.ToInt32(Console.ReadLine());

            if (amzius < 18)
            {
                Console.WriteLine("Negalima pirkti alkoholio ar vairuoti");
            }
            else if (amzius >= 18 && amzius < 20)
            {
                Console.WriteLine("Galima vairuot, negalima alko");
            }
            else
            {
                Console.WriteLine("Galima ir vairuot ir pirkit alkoholi");
            }
            Console.ReadLine();
        }

        private void UZDUOTIS2()
        {
            Console.Write($"Iveskite 1 skaiciu: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Iveskite 2 skaiciu: ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Iveskite 3 skaiciu: ");
            int skaicius3 = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Iveskite 4 skaiciu: ");
            int skaicius4 = Convert.ToInt32(Console.ReadLine());

            if (skaicius1 > 0 && skaicius2 > 0 && skaicius3 > 0 && skaicius4 > 0)
            {
                Console.WriteLine($"Skaiciu suma: {skaicius1 + skaicius2 + skaicius3 + skaicius4}");
                Console.WriteLine($"Skaiciu skirtumas: {skaicius1 - skaicius2 - skaicius3 - skaicius4}");
                Console.WriteLine($"Skaiciu sandauga: {skaicius1 * skaicius2 * skaicius3 * skaicius4}");
                Console.WriteLine($"Skaiciu dalyba: {(double)skaicius1 / skaicius2 / skaicius3 / skaicius4}");
            }
            else
            {
                Console.WriteLine("Kazkuris skaicius nera teigiamas.");
            }
            Console.ReadLine();
        }

        private void UZDUOTIS3()
        {
            int ivestasSkaicius = 1;
            List<int> skaiciuSarasas = new List<int>();

            while (ivestasSkaicius != 0)
            {
                Console.Write("Iveskite skaiciu: ");
                ivestasSkaicius = Convert.ToInt32(Console.ReadLine());
                skaiciuSarasas.Add(ivestasSkaicius);
            }

            int skaiciuSuma = 0;

            foreach (int skaicius in skaiciuSarasas)
            {
                skaiciuSuma += skaicius;
            }

            Console.WriteLine($"Ivestu skaiciu suma: {skaiciuSuma}");
            Console.ReadLine();
        }

        private static void UZDUOTIS4()
        {
            ZodziuDuombaze zodziuDuombaze = new ZodziuDuombaze();
            
            bool prasytiZodzio = true;

            while (prasytiZodzio)
            {
                Console.Write("Iveskite zodi (stop sustabdo): ");
                string zodis = Console.ReadLine();

                if (zodis == "stop")
                {
                    prasytiZodzio = false;
                }
                else if (zodziuDuombaze.zodziuSarasasDuombazeje.Contains(zodis))
                {
                    Console.WriteLine("Dublikatas. Zodis jau buvo irasytas.");
                }
                else
                {
                    zodziuDuombaze.PridetiZodi(zodis);
                    Console.WriteLine("Zodis pridetas!");
                }
            }

            Console.WriteLine("Visi irasyti zodziai: ");
            foreach (var item in zodziuDuombaze.zodziuSarasasDuombazeje)
            {
                Console.Write($"{item}, ");
            }
            Console.ReadLine();
        }
    }
}
