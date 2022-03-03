using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darbas_Namie_1
{
    internal class Pilietis : Zmogus
    {
        public int AsmensKodas { get; set; }
        public string Pilietybe { get; set; }


        public Pilietis(int asmensKodas, string pilietybe, string vardas, string pavarde) : base(vardas,pavarde)
        {
            AsmensKodas = asmensKodas;
            Pilietybe = pilietybe;
        }

        public override void InfoZmogus()
        {
            base.InfoZmogus();
            Console.WriteLine($"Asmens kodas: {AsmensKodas}, pilietybe: {Pilietybe}");
        }
    }
}
