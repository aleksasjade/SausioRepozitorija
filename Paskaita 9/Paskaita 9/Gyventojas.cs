using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_9
{
    internal class Gyventojas : Pilietis
    {
        public string gyvenamojiVieta { get; set; }

        public Gyventojas(string GyvenamojiVieta, int AsmensKodas, string Pilietybe, string Vardas, string Pavarde) : base(AsmensKodas, Pilietybe, Vardas, Pavarde)
        {
            gyvenamojiVieta = GyvenamojiVieta;
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine($"Gyvenamoji vieta {gyvenamojiVieta}");
        }
    }
}
