using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_17
{
    // BusimasTipas == Enemy;
    // BusimasTipas == Hero;
    // BusimasTipas == string;
    internal class UnitController<BusimasTipas> where BusimasTipas : IPrintable, new()
    {
        // private Enemy kintamasis;
        // private Hero kintamasis;

        private BusimasTipas kintamasis;

        public UnitController()
        {
            kintamasis = new BusimasTipas();
        }

        public void Print()
        {
            kintamasis.PrintInfo();
        }
    }
}
