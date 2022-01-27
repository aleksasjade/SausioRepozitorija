using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kortos
{
    internal class Zaidimas
    {
        public List<Zaidejas> Zaidejai { get; private set; }
        public KortuKalade KortuKalade { get; private set; }

        public void SuskaiciuotiTaskus()
        {

        }

        public Zaidimas()
        {
            Zaidejai = new List<Zaidejas>();
        }


        public void Pradeti()
        {
            KortuKalade = new KortuKalade();
            KortuKalade.Sumaisyti();

            foreach (var Korta in KortuKalade.KortuSarasas)
            {
                Console.WriteLine($"{Korta.Zenklas} {Korta.Pavadinimas}");
            }
            
            
            Zaidejai.Clear();

            Console.WriteLine($"Kiek bus zaideju? 2 ar 4?");
            int zaidejuSkaicius = Convert.ToInt32(Console.ReadLine());

            while(zaidejuSkaicius != 2 && zaidejuSkaicius !=4)
            {
                Console.WriteLine("Blogas zaideju skaicius! Kiek bus zaideju? 2 ar 4?");
                zaidejuSkaicius = Convert.ToInt32((Console.ReadLine()));
            }

            for(int i = 0; i > zaidejuSkaicius; i++)
            {
                Console.WriteLine($"Ivesti {i + 1}-o varda:");
                string zaidejoVardas = Console.ReadLine();
                Zaidejai.Add(new Zaidejas(zaidejoVardas));
            }

        }

        public void IsdalintiKortas()
        {
            int kortuIRankaKiekis = KortuKalade.KortuSarasas.Count() / Zaidejai.Count();
            foreach (Zaidejas zaidejas in Zaidejai)
            {
                for (int i = 0; i < kortuIRankaKiekis; i++)
                {
                    zaidejas.kortos.Add(KortuKalade.KortuSarasas[0]);
                    KortuKalade.KortuSarasas.RemoveAt(0);
                }
            }
        }

    }
}
