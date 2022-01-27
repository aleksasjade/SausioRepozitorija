using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_8
{
    internal class Garazas
    {
        public List<Automobilis> AutomobiliuSarasas;
        public int Sutaisyti;

        public Garazas(List<Automobilis> masinugarazas)
        {
            AutomobiliuSarasas = masinugarazas;
        }

        public void Taisyti()
        {
            foreach (var auto in AutomobiliuSarasas)
            {
                if (auto.galimaVaziuoti == false)
                {
                    auto.rida = 0;
                    auto.galimaVaziuoti = true;
                    Console.WriteLine($"Sutaisytas {auto.modelis}");
                }
            }
        }

        public void BandytiVaziuoti()
        {
            foreach (var auto in AutomobiliuSarasas)
            {
                Console.WriteLine($"Modelis {auto.modelis} vaziuoja, rida {auto.rida}");
                auto.Vaziuoti();
            }    

        }
    }
}
