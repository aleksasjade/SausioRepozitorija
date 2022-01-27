using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_8
{
    internal class Automobilis
    {
        public string modelis;
        public int rida;
        public bool galimaVaziuoti;

        public Automobilis(string Modelis, int Rida, bool GalimaVaziuoti)
        {
            modelis = Modelis;
            rida = Rida;
            galimaVaziuoti = GalimaVaziuoti;
        }
        public Automobilis(string Modelis, int Rida)
        {
            modelis=Modelis;
            rida=Rida;
            galimaVaziuoti = false;
        }

        public void Vaziuoti()
        {

        if (galimaVaziuoti && rida < 10)
        {
            rida++;
                Console.WriteLine($"Modelis {modelis}, rida {rida}, galima vaziuoti");
        }
        else if (rida >= 10)
        {
            galimaVaziuoti=false;
                Console.WriteLine($"Modelis {modelis}, rida {rida}, reikia taisyti");
        }
            
        }
    }
}
