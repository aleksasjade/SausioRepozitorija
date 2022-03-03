using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_13
{
    internal class EnumoKlase
    {
        public Enumas VedybinePadetis { get; set; }

        public EnumoKlase(Enumas vedybinePadetis)
        {
            VedybinePadetis = vedybinePadetis;
        }
    }
}
