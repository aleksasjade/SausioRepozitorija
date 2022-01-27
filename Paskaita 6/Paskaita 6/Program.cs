using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, int> zodynas = new Dictionary<int, int>();

            //Console.WriteLine("Iveskite skaiciu");
            //int skaicius = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i <10; i++)
            //{
            //    zodynas.Add(skaicius + i, skaicius + 1 + i);
            //}

            //var apverstasZodynas = zodynas.Reverse();

            //foreach (var item in apverstasZodynas)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();

            /////////////////////////////////////////////////////////

            //List<int> skaiciuSarasas = new List<int>();

            //int skaicius = Convert.ToInt32(Console.ReadLine());
            //while (skaicius >= 0)
            //{
            //    skaiciuSarasas.Add(skaicius);
            //    skaicius = Convert.ToInt32(Console.ReadLine());
            //}

            ////for (int i = 0; i < skaiciuSarasas.Count(); i++)
            ////{
            ////    Console.WriteLine($"skaicius {i} yra {skaiciuSarasas[i]}");
            ////}

            //foreach (var item in skaiciuSarasas)
            //{
            //    Console.WriteLine($"indeksas {skaiciuSarasas.IndexOf(item)} yra {item}");
            //}    
            //Console.ReadKey();

            /////////////////////////////////////////////////////////
            ///

            Dictionary<string, int> zodynas = new Dictionary<string, int>();

            string raktas = Convert.ToString(Console.ReadLine());
            int reiksme = Convert.ToInt32(Console.ReadLine());

            while (zodynas.ContainsKey(raktas) is false)
            {
                zodynas.Add(raktas, reiksme);
                raktas = Convert.ToString(Console.ReadLine());
                reiksme = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var item in zodynas)
            {
                Console.WriteLine(zodynas);
            }
            Console.ReadKey();

        }
    }
}
