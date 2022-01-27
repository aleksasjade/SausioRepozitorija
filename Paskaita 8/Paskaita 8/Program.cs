using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Automobilis> automobiliuSarasas = new List<Automobilis>();

            automobiliuSarasas.Add(new Automobilis("audi", 5, true));
            automobiliuSarasas.Add(new Automobilis("toyota", 6));
            automobiliuSarasas.Add(new Automobilis("vw", 8, true));
            automobiliuSarasas.Add(new Automobilis("dacia", 2, false));

            Garazas garazas = new Garazas(automobiliuSarasas);

            Console.Write("Vaziuoti ar taisyti?: ");
            string pasirinkimas = Console.ReadLine().ToLower();

            while (pasirinkimas == "vaziuoti" || pasirinkimas == "taisyti")
            {
                switch (pasirinkimas)
                {
                    case "vaziuoti":
                        garazas.BandytiVaziuoti();
                        break;
                    case "taisyti":
                        garazas.Taisyti();
                        break;
                }

            Console.Write("Vaziuoti ar taisyti?: ");

            }

            Console.ReadLine();
        }
        
       
    }
}
