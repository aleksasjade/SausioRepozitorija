using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_12
{
    static class General
    {
        public static int NuskaitytiSveikajiSkaiciu()
        {
            Console.Write("Iveskite sveikaji skaiciu: ");
            int sveikasisSkaicius = Convert.ToInt32(Console.ReadLine());
            return sveikasisSkaicius;
        }

        public static double NuskaitytiDoubleSkaiciu()
        {
            Console.Write("Iveskite double skaiciu: ");
            double doubleisSkaicius = Convert.ToDouble(Console.ReadLine());
            return doubleisSkaicius;
        }

        public static void PrintIntArray(int[] masyvas)
        {
            foreach(var item in masyvas)
            {
                Console.Write($"{item} ");

            }
        }
    }
}
