using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_14._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder statytojas = new StringBuilder("");

            for (int i = 1; i <= 100; i++)
            {
                statytojas.Append(i.ToString());
                statytojas.Append(" eilute");
                statytojas.Replace((i-1).ToString()+" eilute", "");

                Console.WriteLine(statytojas);
            }

            Console.ReadLine();

        }


        private void stringPasibandymai()
        {
            string tekstas = "Labas vakaras";

            char simbolis1 = tekstas[4];

            Console.WriteLine(simbolis1);

            int simboliuSkaicius = tekstas.Length;

            Console.WriteLine(simboliuSkaicius);

            string intervalas = tekstas.Substring(0, 5);

            Console.WriteLine(intervalas);

            tekstas = tekstas.Remove(0, 6);

            Console.WriteLine(tekstas);

            tekstas = tekstas.Replace("a", "A");

            Console.WriteLine(tekstas);

            tekstas = tekstas.Insert(0, "LABAS ");

            Console.WriteLine(tekstas);

            string tekstukas = " sveiki";

            string sudetasTekstas = string.Concat(tekstas, tekstukas);

            Console.WriteLine(sudetasTekstas);

            tekstas = sudetasTekstas;





            Console.ReadLine();
        }

        private void trikecas()
            {
            try
            {
                int[] masyvas = new int[3];
                int test = Convert.ToInt32(Console.ReadLine());
                masyvas[5] = test;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
