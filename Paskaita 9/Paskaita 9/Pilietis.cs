using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_9
{
    internal class Pilietis : Zmogus
    {
        public int asmensKodas { get; set; }
        public string pilietybe { get; set; }

        public Pilietis(int AsmensKodas, string Pilietybe, string Vardas, string Pavarde) : base(Vardas, Pavarde)
        {
            asmensKodas = AsmensKodas;
            pilietybe = Pilietybe;

        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine($"Asmens kodas {asmensKodas}, pilietybe {pilietybe}");
        }



    }
}
