using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darbas_Namie_1
{
    internal class Medis
    {

        public int SakuSkaicius { get; private set; }

        public Medis()
        {
            int SakuSkaicius = 0;
        }

        public void Augti()
        {
            SakuSkaicius++;
        }

    }
}
