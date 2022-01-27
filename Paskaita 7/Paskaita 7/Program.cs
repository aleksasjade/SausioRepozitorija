using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skaiciuotuvas pirmas = new Skaiciuotuvas(1, 2);
            //Skaiciuotuvas antras = new Skaiciuotuvas(3, 4);
            //Skaiciuotuvas trecias = new Skaiciuotuvas(5, 6);

            //pirmas.Suma();
            //antras.Suma();
            //trecias.Suma();
            //pirmas.Skirtumas();
            //antras.Skirtumas();
            //trecias.Skirtumas();
            //pirmas.Sandauga();
            //antras.Sandauga();
            //trecias.Sandauga();
            //pirmas.Dalyba();
            //antras.Dalyba();
            //trecias.Dalyba();

            //Console.ReadKey();
            ////////////////////////////////////////////////////
            ///

            //Apskritimas pirmas = new Apskritimas(3);

            //pirmas.GautiPlota();
            //pirmas.GautiIlgi();
            //Console.ReadKey();

            //////////////////////////////////////////////////

            //Keturkampis op = new Keturkampis(4, 5);
            //Keturkampis ok = new Keturkampis(4.4, 5.5);

            //op.GautiPlota();
            //op.GautiIlgi();
            //ok.GautiPlota();
            //ok.GautiIlgi();

            //Console.ReadKey();

            //////////////////////////////////////////////////

            //Trikampis pirmas = new Trikampis(13.2, 14.5, 16.4);
            //Trikampis antras = new Trikampis(1.5, 2.5, 3.5);

            //Console.WriteLine($"Trikampio perimetras {pirmas.Perimetras()}, pusperimetris {pirmas.Pusperimetris()}, plotas {pirmas.Plotas()}");
            //Console.WriteLine($"Trikampio perimetras {antras.Perimetras()}, pusperimetris {antras.Pusperimetris()}, plotas {antras.Plotas()}");
            //Console.ReadKey();

            /////////////////////////////////////////////////


            //Medis berzas = new Medis();

            //Console.WriteLine("Ar norite auginti medi?");
            //while(Console.ReadLine().ToLower() == "y")
            //{
            //    berzas.Augti();
            //    Console.WriteLine("Ar norite auginti medi?");
            //}

            //Console.WriteLine($"Medis turi {berzas.SakuSkaicius} saku");
            //Console.ReadKey();


            List<Snipas> snipuSarasas = new List<Snipas>();
            for(int i = 0; i < 10; i++)
            {
                Snipas snipas = new Snipas($"snipas{i}");
                snipuSarasas.Add(snipas);
            }

            for(int i = 1;i <= 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    snipuSarasas[i = 1].infiltruotis();
                }
            }

            Console.ReadLine();
        }
    }

}
