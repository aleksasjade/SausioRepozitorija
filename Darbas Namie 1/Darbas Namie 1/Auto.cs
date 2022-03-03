using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darbas_Namie_1
{
    internal class Auto
    {
        public string Modelis;
        public int Rida;
        public bool GalimaVaziuoti;

        public Auto(string modelis, int rida, bool galimaVaziuoti)
        {
            Modelis = modelis;
            Rida = rida;
            GalimaVaziuoti = galimaVaziuoti;
        }
        public Auto(string modelis, int rida)
        {
            Modelis = modelis;
            Rida = rida;
            GalimaVaziuoti = false;
        }

        public void Vaziuoti()
        {
            if (GalimaVaziuoti == true && Rida < 10)
            {
                Rida++;
                Console.WriteLine($"Modelis {Modelis}, rida {Rida}, galima vaziuoti");
            }
            else if (Rida >= 10 || GalimaVaziuoti == false)
            {
                GalimaVaziuoti = false;
                Console.WriteLine($"Modelis {Modelis}, rida {Rida}, reikia taisyti");
            }
        }
    }
}
