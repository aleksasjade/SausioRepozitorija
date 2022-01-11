using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND___kepykla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kepalai iskepti per valanda: ");
            int kepalai = Convert.ToInt32(Console.ReadLine());
            Console.Write("Darbuotoju skaicius: ");
            int darbuotojai = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kepalo savikaina, Eur: ");
            int savikaina = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kepalo pardavimo kaina, Eur: ");
            int kaina = Convert.ToInt32(Console.ReadLine());
            var darboValandos = 8;
            var visoIskepta = kepalai * darboValandos * darbuotojai;
            Console.WriteLine($"Kepykla viso iskeps {visoIskepta} kepalus");
            var pajamos = visoIskepta * kaina;
            var savikainaViso = visoIskepta * savikaina;
            Console.WriteLine($"Kepalu savikaina {savikainaViso} Eur\nKepalu pajamos {pajamos} Eur\nPelnas {pajamos - savikainaViso} Eur");
            Console.ReadLine();
        }
    }
}
