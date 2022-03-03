using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darbas_Namie_1
{
    internal class Gyventojas : Pilietis
    {
        public string GyvenamojiVieta { get; set; }


        public Gyventojas(string gyvenamojiVieta, int asmensKodas, string pilietybe, string vardas, string pavarde) : base(asmensKodas,pilietybe,vardas,pavarde)
        {
            GyvenamojiVieta = gyvenamojiVieta;
        }

        public override void InfoZmogus()
        {
            base.InfoZmogus();
            Console.WriteLine($"Gyvenamoji vieta: {GyvenamojiVieta}");
        }
    }
}
