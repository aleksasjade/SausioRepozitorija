using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darbas_Namie_1
{
    internal class Garazas
    {
        public List<Auto> automobiliuSarasas;

        public Garazas(List<Auto> masinuGarazas)
        {
            automobiliuSarasas = masinuGarazas;
        }
        public void Taisyti()
        {
            foreach (var auto in automobiliuSarasas)
            {
                if (auto.GalimaVaziuoti == false)
                {
                    auto.Rida = 0;
                    auto.GalimaVaziuoti = true;
                    Console.WriteLine($"Automobilis {auto.Modelis} sutaisytas, rida {auto.Rida}");
                }
            }
        }

        public void BandytiVaziuoti()
        {
            foreach (var auto in automobiliuSarasas)
            {
                
                auto.Vaziuoti();
            }    
        }
    }
}
