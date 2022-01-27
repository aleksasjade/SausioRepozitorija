using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kortos
{
    internal class SkaitineKorta : Korta
    {
        public SkaitineKorta(int verte, string zenklas) : base(verte.ToString(),verte,zenklas)
        {

        }
    }
}
