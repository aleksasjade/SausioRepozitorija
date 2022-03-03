using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darbas_Namie_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Pavyzdys su masinom
            //    Automobilis auto1 = new Automobilis("Audi", "A6", 100000, 1996);
            //    Automobilis auto2 = new Automobilis("VW", "Passat", 200000, 2016);
            //    Automobilis auto3 = new Automobilis("Toyota", "Rav4", 5000, 2020);

            //    auto1.Informacija();
            //    auto2.Informacija();
            //    auto3.Informacija();

            //    Console.ReadKey();

            /////////////////////////////////////////////////////////////////////////////

            //// UZDUOTIS 1
            //Apskritimas apskritimas1 = new Apskritimas(5.4);
            //Keturkampis keturkampis1 = new Keturkampis(5.4, 4.5);

            //apskritimas1.Info();
            //keturkampis1.Info();

            //Console.ReadKey();
            /////////////////////////////////////////////////////////////////////////////

            // Uzduotis 2 Medis
            //Medis medis1 = new Medis();

            //Console.Write("Ar norite auginti medi? y/n: ");
            //string pasirinkimas = Console.ReadLine().ToLower();
            //while (pasirinkimas == "y")
            //{
            //    medis1.Augti();
            //    Console.WriteLine($"Medis turi {medis1.SakuSkaicius} saku");
            //    Console.Write("Ar norite auginti medi? y/n: ");
            //    pasirinkimas = Console.ReadLine().ToLower();
            //}

            //Console.WriteLine($"Medis turi {medis1.SakuSkaicius} saku");
            //Console.ReadKey();

            ////////////////////////////////////////////////////////////////////
            //// Snipai

            //List<Snipas> snipuSarasas = new List<Snipas>();

            //for(int i = 0; i < 10; i++)
            //{
            //    Snipas snipas = new Snipas($"Snipas{i+1}");
            //    snipuSarasas.Add(snipas);
            //}

            //for(int i = 1; i <= 10; i++)
            //{
            //    for(int j = 0; j < i; j++)
            //    {
            //        snipuSarasas[i-1].Infiltruotis();
            //    }
            //}

            //Console.ReadKey();
            ////////////////////////////////////////////////////////////////////
            ///

            //// Uztuotis 4 / Auto ir Garazas
            //List<Auto> automobiliuSarasas = new List<Auto>();
            //automobiliuSarasas.Add(new Auto("Audi", 2, false));
            //automobiliuSarasas.Add(new Auto("Toyota", 8, true));
            //automobiliuSarasas.Add(new Auto("VW", 5));
            //automobiliuSarasas.Add(new Auto("Honda", 6, true));

            //Garazas garazas = new Garazas(automobiliuSarasas);

            //Console.Write("Vaziuoti ar taisyti: ");
            //string pasirinkimas = Console.ReadLine().ToLower();

            //while (pasirinkimas == "vaziuoti" || pasirinkimas == "taisyti")
            //{
            //    if (pasirinkimas == "vaziuoti")
            //    {
            //        garazas.BandytiVaziuoti();
            //    }
            //    else if (pasirinkimas == "taisyti")
            //    {
            //        garazas.Taisyti();
            //    }
            //Console.Write("Vaziuoti ar taisyti?: ");
            //pasirinkimas = Console.ReadLine();
            //}

            //Console.ReadLine();

            ////////////////////////////////////////////////////////////////////

            //// 2 Uzduotis, Pilietis
            //Zmogus zmogus1 = new Zmogus("Tomas", "Tomukas");
            //Pilietis pilietis1 = new Pilietis(45, "anglas", "Jonas", "Jonukas");
            //Gyventojas gyventojas1 = new Gyventojas("Vilnius", 45324234, "lietuvis", "Ignas", "Ignukas");

            //zmogus1.InfoZmogus();
            //pilietis1.InfoZmogus();
            //gyventojas1.InfoZmogus();

            //Console.ReadKey();       

            ////////////////////////////////////////////////////////////////////

            //// KortuKalade

            KortuKalade kortuKalade = new KortuKalade();

            kortuKalade.Sumaisyti();

            foreach (Korta korta in kortuKalade.KortuSarasas)
            {
                Console.WriteLine($"{korta.Pavadinimas} {korta.Zenklas}");
            }

            Console.ReadLine();

            ////////////////////////////////////////////////////////////////////



        }

    }
}
