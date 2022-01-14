using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Iveskite skaiciu: ");
            //int skaicius = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < skaicius; i+=3)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.Read();

            //Console.Write("Iveskite skaiciu: ");
            //int skaicius = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < skaicius; i++)
            //{
            //    if (i % 3 == 0)
            //        Console.WriteLine(i);
            //}
            //Console.Read();

            /////////////////////////////////////////////////////////////
            ///

            //Console.WriteLine("Iveskite pradzios skaiciu: ");
            //int pradzia = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Iveskite pabaigos skaiciu: ");
            //int pabaiga = Convert.ToInt32(Console.ReadLine());

            //if (pradzia > pabaiga)
            //{
            //    Console.WriteLine("blogi reziai");
            //}    
            //else
            //{
            //    for (int i = pradzia; i <= pabaiga; i++)
            //    {
            //        Console.WriteLine($"{i} {i * i}");
            //    }
            //}
            //Console.Read();

            /////////////////////////////////////////////////////////////////

            //Console.Write("Iveskite skaiciu: ");
            //int skaicius = Convert.ToInt32(Console.ReadLine());
            //int skaiciuSuma = 0;

            //for (int i = 1; i < skaicius; i++)
            //{
            //    if (i % 3 == 0 || i % 5 == 0)
            //    {
            //        skaiciuSuma += i;
            //    }

            //}
            //Console.WriteLine($"Skaiciu kurie dalinasi is 3 arba 5 suma: {skaiciuSuma}");
            //Console.Read();

            ///////////////////////////////////////////////////

            //    Console.Write("Iveskite skaiciu: ");
            //    int skaicius = Convert.ToInt32(Console.ReadLine());
            //    int sandauga = 1;

            //    for (int i = 1; i < 100; i++)
            //    {
            //        if (i % 7 == 0)
            //        {
            //            sandauga *= i;
            //        }
            //    }
            //    Console.WriteLine($"Skaiciu, kurie dalinasi is 7 sandauga: {sandauga}");
            //    Console.Read();
            //
            //

            //////////////////////////////////////////////////////////

            //console.write("pasirinkite 1 arba 2: \n 1 - laptopas\n 2 - stacionaras\niveskite pasirinkima: ");
            //int pasirinkimas = convert.toint32(console.readline());

            //while (pasirinkimas < 1 || pasirinkimas > 2)
            //{
            //    console.write("neteisingas pasirinkimas, pasirinkite is naujo: ");
            //    pasirinkimas = convert.toint32(console.readline());
            //}

            //if (pasirinkimas == 1)
            //{
            //    console.writeline($"jusu pasirinkimas yra laptopas");
            //}
            //else
            //{
            //    console.writeline($"jusu pasirinkimas yra stacionaras");
            //}
            //console.read();

            //////////////////////////////////////////////////////////

            Console.Write("Iveskite skaiciu: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());

            while (skaicius > 0)
            {
                int atimtasSkaicius = skaicius - 1;
                skaicius--;
                Console.WriteLine($"{atimtasSkaicius}");
            }
            Console.Read();
        }
    }
}
