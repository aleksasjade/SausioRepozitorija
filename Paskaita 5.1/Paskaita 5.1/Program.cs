using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Iveskite skaiciu: ");
            //int skaicius = Convert.ToInt32(Console.ReadLine());
            //int suma = 0;

            //while (skaicius > 0)
            //{

            //    Console.WriteLine($"{skaicius}");
            //    skaicius--;
            //    if (skaicius % 2 == 0)
            //    {
            //        suma = suma + skaicius;
            //    }
            //}
            //Console.WriteLine($"Lyginiu skaiciu sumu: {suma}");
            //Console.Read();

            /////////////////////////////////////////////////////
            ///

            //bool skaiciuoti = true;

            //while (skaiciuoti is true)
            //{
            //    Console.Write("Iveskite pirma skaiciu: ");
            //    int skaicius1 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Iveskite antra skaiciu: ");
            //    int skaicius2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine($"Pasirinkite veiksma: \n1 - Sudetis\n2 - Atimtis\n3 - Daugyba\n4 - Dalyba");
            //    int pasirinkimas = Convert.ToInt32(Console.ReadLine());
            //    switch (pasirinkimas)
            //    {
            //        case 1:
            //            Console.WriteLine($"{skaicius1} + {skaicius2} = {skaicius1 + skaicius2}");
            //            break;
            //        case 2:
            //            Console.WriteLine($"{skaicius1} - {skaicius2} = {skaicius1 - skaicius2}");
            //            break;
            //        case 3:
            //            Console.WriteLine($"{skaicius1} * {skaicius2} = {skaicius1 * skaicius2}");
            //            break;
            //        case 4:
            //            Console.WriteLine($"{skaicius1} + {skaicius2} = {(double)skaicius1 / skaicius2}");
            //            break;
            //        default:
            //            Console.WriteLine($"Netinkamas pasirinkimas");
            //            break;
            //    }
            //    Console.WriteLine("Bandyti dar karta? y/n");
            //    string darKarta = Console.ReadLine();

            //    switch (darKarta)
            //    {
            //        case "y":
            //            break;
            //        case "n":
            //            skaiciuoti = false;
            //            break;
            //        default:
            //            Console.WriteLine("Netinkamas pasirinkimas. Bandykite dar karta: ");
            //            break;
            //    }
            //    }
            /////////////////////////////////////////////////////
            ///

         
            int reziai1 = 1;
            int reziai2 = 50;
            int slaptasSkaicius = 38;
            Console.WriteLine($"Bandykite atspeti slapta skaiciu nuo {reziai1} iki {reziai2}");
            bool atspejo = false;

            while (atspejo is false)
            {
                Console.Write("Iveskite spejima: ");
                int spejimas = Convert.ToInt32(Console.ReadLine());
                if (spejimas < reziai1 || spejimas > reziai2)
                {
                    Console.WriteLine($"Spejimas uz reziu ribu. Bandykite dar karta.");
                }
                else if (spejimas == slaptasSkaicius)
                {
                    Console.WriteLine($"Atspejote! Spaltas skaicius buvo {slaptasSkaicius}");
                    atspejo = true;
                }
                else if (spejimas < slaptasSkaicius)
                {
                    Console.WriteLine("Slaptas skaicius yra didesnis. Bandykite dar karta.");
                }
                else if (spejimas > slaptasSkaicius)
                {
                    Console.WriteLine("Slaptas skaicius yra mazesnis. Bandykite dar karta.");
                }
            }
            Console.Read();
        }
    }
    }
