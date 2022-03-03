using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_19
{
    internal class Studentai
    {
        public int Id;
        public string Name;
        public int Age;
        public double AverageMark;
        public bool IsGettingTuition;

        public Studentai(int aId, string aName, int aAge, double aAverageMark, bool aIsGettingTuition)
        {
            Id = aId;
            Name = aName;
            Age = aAge;
            AverageMark = aAverageMark;
            IsGettingTuition = aIsGettingTuition;
        }
    }
}
