using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_15
{
    internal class ZodziuDuombaze
    {
        public List<string> zodziuSarasasDuombazeje = new List<string>();
        public void PridetiZodi(string zodis)
        {
            zodziuSarasasDuombazeje.Add(zodis);
        }
    }


}
