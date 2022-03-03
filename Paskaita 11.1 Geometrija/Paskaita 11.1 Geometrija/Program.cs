using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_11._1_Geometrija
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Kvadratas kvadratas = new Kvadratas(5);
            Console.WriteLine( kvadratas.pavadinimas);

            List<Figura> figuruSarasas = new List<Figura>()
            {
            new Kvadratas(3),
            new Staciakampis(3, 4),
            new StatusisTrikampis(3, 4),
            new Apskritimas(3),
            };

            List<IGeometrija> geometrijuSarasas = new List<IGeometrija>
            {
                new Kvadratas(3),
                new Staciakampis(3,4),
                new StatusisTrikampis(3,4),
                new Apskritimas(3),
            };

            List<IInformacija> informacijuSarasas = new List<IInformacija>
            {
                new Kvadratas(3),
                new Staciakampis(3,4),
                new StatusisTrikampis(3,4),
                new Apskritimas(3),
            };

            //foreach (var figura in figuruSarasas)
            //{
            //    Console.WriteLine(figura.pavadinimas);
            //}

            //foreach (var geometrija in geometrijuSarasas)
            //{
            //    Console.WriteLine($"{geometrija} perimetras yra {geometrija.Perimetras()}");
            //    Console.WriteLine($"{geometrija} plotas yra {geometrija.Plotas()}");
            //}

            foreach (var info in informacijuSarasas)
            {
                info.Info();
            }

            Console.ReadLine();
        }


    }
}
