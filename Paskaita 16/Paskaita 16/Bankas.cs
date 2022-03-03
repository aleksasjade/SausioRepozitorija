using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_16
{
    internal class Bankas
    {
        public event EventHandler<string> PridejoPinigu;
        public event EventHandler<string> PervedePinigu;
        public event EventHandler<string> PakeitePiniguValiuta;
        public event EventHandler<string> IvykoTranzakcija;

        public void PridetiPinigu(double money)
        {
            string zinute = $"Pridejo {money}";
            IvykoTranzakcija.Invoke(this,zinute);
            PridejoPinigu.Invoke(this, zinute);
        }

        public void PervestiPinigu(double money, string saskaitosNr)
        {
            string zinute = $"Pervede {money} i {saskaitosNr}";
            IvykoTranzakcija.Invoke(this, zinute);
            PridejoPinigu.Invoke(this, zinute);
        }

        public void PakeistiValiuta(double money, string valiuta)
        {
            string zinute = $"Pakeite valiuta {money} {valiuta}";
            IvykoTranzakcija.Invoke(this, zinute);
            PridejoPinigu.Invoke(this, zinute);
        }

        public override string ToString()
        {
            return "bankas";
        }
    }
}
