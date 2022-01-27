using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, int> zodynas = new Dictionary<string, int>();

            //string ivestis = Convert.ToString(Console.ReadLine());
            //string[] elementai = ivestis.Split(',');

            //while (!zodynas.ContainsKey(elementai[0]))
            //{
            //    int skaicius = Convert.ToInt32(elementai[1]);
            //    zodynas.Add(elementai[0], skaicius);

            //    ivestis = Console.ReadLine();
            //    elementai = ivestis.Split(',');
            //}

            //foreach (KeyValuePair<string, int> pora in zodynas)
            //{
            //    Console.WriteLine($"{pora.Key} {pora.Value}");
            //}
            //Console.ReadKey();

            /////////////////////////////////////////////////////
            ///

            //Dictionary<string, int> zodynas = new Dictionary<string, int>();

            //Console.WriteLine("Iveskite rakta: ");
            //string raktas = Convert.ToString(Console.ReadLine());
            //Console.WriteLine("Iveskite reiksme: ");
            //int reiksme = Convert.ToInt32(Console.ReadLine());

            //while (zodynas.ContainsKey(raktas) is false)
            //{
            //    zodynas.Add(raktas, reiksme);

            //    Console.WriteLine("Iveskite rakta: ");
            //    raktas = Convert.ToString(Console.ReadLine());
            //    Console.WriteLine("Iveskite reiksme: ");
            //    reiksme = Convert.ToInt32(Console.ReadLine());

            //}

            //foreach (KeyValuePair<string, int> pora in zodynas)
            //{
            //    Console.WriteLine($"{pora.Key} {pora.Value}");
            //}

            //Console.WriteLine("Iveskite rakta, kurio reiksmes norite");
            //string ivestasRaktas = Console.ReadLine();

            //int reiksmePasirinkta = zodynas[ivestasRaktas];

            //Console.WriteLine($"Pasirinkta reiksme yra {reiksmePasirinkta}");
            //Console.WriteLine($"Reiksmes kvadratas yra {reiksmePasirinkta * reiksmePasirinkta}");

            //Console.ReadKey();

            /////////////////////////////////////////////


            Console.Write("Piramides aukstis: ");
            int aukstis = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= aukstis; i++)
            {
                for(int j = 1; j <= aukstis-i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2*i-1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
