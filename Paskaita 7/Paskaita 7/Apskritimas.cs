using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_7
{
    internal class Apskritimas
    {
        double apskritimoSpindulys;


        public Apskritimas(double ApskritimoSpindulys)
        {
            apskritimoSpindulys = ApskritimoSpindulys;
        }

        public void GautiIlgi()
        {
            Console.WriteLine($"Apskritimo, kurio spindulys yra {apskritimoSpindulys} ilgis yra {2 * Math.PI * apskritimoSpindulys}");
        }
        public void GautiPlota()
        {
            Console.WriteLine($"Apskritimo, kurio spindulys yra {apskritimoSpindulys} plotas yra {Math.PI * apskritimoSpindulys * apskritimoSpindulys}");
        }
    }


}
