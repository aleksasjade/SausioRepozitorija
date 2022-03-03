using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_19
{
    internal class StudentuLokacija
    {
        public string Name;
        public int Age;
        public string Town;
        public int HouseNumber;

        public StudentuLokacija (string aName, int aAge, string aTown, int aHouseNumber)
        {
            Name = aName;
            Age = aAge;
            Town = aTown;
            HouseNumber = aHouseNumber;
        }
    }
}
