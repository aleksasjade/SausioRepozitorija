using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_11
{
    interface IMatematika
    {
        int Prideti(int Skaicius1);
        int Atimti(int Skaicius1);
        int Padauginti(int Skaicius1);
        double Padalinti(double Skaicius1);
        int PakeltiKvadratu();
        int PakeltiKubu();
    }
}
