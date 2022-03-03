using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darbas_Namie_1
{
    internal class Automobilis
    {
        public string Marke;
        public string Modelis;
        public int Rida;
        public int Metai;

        public Automobilis(string marke, string modelis, int rida, int metai)
        {
            Marke = marke;
            Modelis = modelis;
            Rida = rida;
            Metai = metai;
        }

        public void Informacija()
        {
            Console.WriteLine($"Marke: {Marke}, modelis: {Modelis}, rida: {Rida}, metai: {Metai}");
        }

    }
}
