using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_17
{
    internal class Studentas
    {
        public int id { get; }
        public string name { get; }
        public int age { get; }
        public double averageMark { get; }
        public bool isGettingTuition { get; }

        public Studentas(int aId, string aName, int aAge, double aAverageMark, bool AIsGettingTuition )
        {
            id = aId;
            name = aName;
            age = aAge;
            averageMark = aAverageMark;
            isGettingTuition = AIsGettingTuition;
        }
    }

}
