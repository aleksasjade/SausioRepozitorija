using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_18.Extensions
{
    internal static class IntExtensions
    {
        public static int PowerTwo(this int skaicius)
        {
            return skaicius * skaicius;
        }
    }
}
