using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_17
{
    internal class Hero : IPrintable
    {
        public void PrintInfo()
        {
            Console.WriteLine("Labas, as esu Hero");
        }
    }
}
