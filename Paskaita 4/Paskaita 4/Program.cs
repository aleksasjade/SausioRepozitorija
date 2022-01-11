using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //koksTekstas("Aleksas");

            ///////////////////////////////////////////

            //Console.WriteLine("Jusu vardas:");
            //string vardas = Convert.ToString(Console.ReadLine());
            //Console.WriteLine("Jusu amzius: ");
            //int amzius = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Jusu hobis: ");
            //string hobis = Convert.ToString(Console.ReadLine());
            //pasisveikinimas(vardas, amzius, hobis);

            ///////////////////////////////////////////

            //Console.Write("Iveskite pirma skaiciu: ");
            //int skaicius1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Iveskite antra skaiciu: ");
            //int skaicius2 = Convert.ToInt32(Console.ReadLine());

            //skaiciuotuvas(skaicius1,skaicius2);

            //////////////////////////////////////////

            int[] skaiciai = new int[3];
            Console.Write("Iveskite pirma skaiciu: ");
            skaiciai[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite antra skaiciu: ");
            skaiciai[1] = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Iveskite trecia skaiciu: ");
            skaiciai[2] = Convert.ToInt32(Console.ReadLine()); 

            char[] raides = new char[3];
            Console.Write("Iveskite pirma raide: ");
            raides[0] = Convert.ToChar(Console.ReadLine());
            Console.Write("Iveskite antra raide: ");
            raides[1] = Convert.ToChar(Console.ReadLine());
            Console.Write("Iveskite trecia raide: ");
            raides[2] = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine($"Jusu skaiciai: {skaiciai[0]}, {skaiciai[1]}, {skaiciai[2]}");
            Console.WriteLine($"Jusu raides: {raides[0]}, {raides[1]}, {raides[2]}");
            Console.Read();

        }
        public static void koksTekstas(string tekstas)
        {
            Console.WriteLine(tekstas);
            Console.Read();
        }

        public static void pasisveikinimas(string vardas, int amzius, string hobis)
        {
            Console.WriteLine($"Labas, {vardas} ({amzius} m.).\nJusu hobis yra: {hobis}");
            Console.Read();
        }

        public static void skaiciuotuvas(int skaicius1, int skaicius2)
        {
            int suma = skaicius1 + skaicius2;
            int skirtumas = skaicius1 - skaicius2;
            int sandauga = skaicius1 * skaicius2;
            double dalyba = (double) skaicius1 / skaicius2;

            Console.WriteLine($"{skaicius1} + {skaicius2} = {suma}");
            Console.WriteLine($"{skaicius1} - {skaicius2} = {skirtumas}");
            Console.WriteLine($"{skaicius1} * {skaicius2} = {sandauga}");
            Console.WriteLine($"{skaicius1} / {skaicius2} = {dalyba}");
            Console.Read();
        }
    }
}
