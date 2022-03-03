using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SukurtasStructas struktas = new SukurtasStructas("TEXT1 STRUKTURA", 111111, new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            //SukurtaKlase klase = new SukurtaKlase("TEXT1 KLASE", 10101010, new List<int> { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 });

            //struktas.PrintData();
            //klase.PrintData();

            //struktas.Skaicius = 22222222;
            //klase.Skaicius = 21212121;
            //struktas.Tekstas = "TEXT2 STRUKTURA";
            //klase.Tekstas = "TEXT2 KLASE";
            //struktas.Sarasiukas[0] = 2222222;
            //klase.Sarasiukas[0] = 21212121;

            //Console.WriteLine("PRIES METODA.........................");
            //struktas.PrintData();
            //klase.PrintData();

            //Metodas(klase, struktas);

            //Console.WriteLine("PO METODO.........................");
            //struktas.PrintData();
            //klase.PrintData();


            //Console.ReadLine();

            EnumoKlase klase1 = new EnumoKlase(Enumas.Vedes);
            EnumoKlase klase2 = new EnumoKlase(Enumas.Nevedes);

            AtspausdintiInfo(klase1.VedybinePadetis);
            AtspausdintiInfo(klase2.VedybinePadetis);
            Console.ReadLine();



        }
        public static void AtspausdintiInfo(Enumas enumas)
        {
            switch (enumas)
            {
                case Enumas.Vedes:
                    Console.WriteLine("Vedes zmogus");
                    break;
                case Enumas.Nevedes:
                    Console.WriteLine("Nevedes zmogus");
                    break;

            }

        }

        //public static void Metodas(SukurtaKlase K, SukurtasStructas S)
        //{
        //    S.Skaicius = 33333333;
        //    K.Skaicius = 31313131;
        //    S.Tekstas = "TEXT3 STRUKTURA";
        //    K.Tekstas = "TEXT3 KLASE";
        //    S.Sarasiukas = new List<int> { 4, 5, 6 };
        //    K.Sarasiukas = new List<int> { 4, 5, 6 };
        //    Console.WriteLine("METODAS:..................................");
        //    S.PrintData();
        //    K.PrintData();
        //}
    }
}
