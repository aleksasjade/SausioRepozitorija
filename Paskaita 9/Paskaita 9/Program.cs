using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zmogus zmogelis = new Zmogus("Tomas", "Tomukas");
            Pilietis pilietis = new Pilietis(123, "lietuvis", "Rokas", "Rokiukas");
            Gyventojas gyventojas = new Gyventojas("Vilnius", 43321, "lietuvis", "Linas", "Liniukas");

            zmogelis.Info();
            pilietis.Info();
            gyventojas.Info();

            Console.ReadKey();
        }
    }
}
