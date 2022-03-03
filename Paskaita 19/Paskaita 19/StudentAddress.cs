using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_19
{
    internal class StudentuAdresas
    {
        public int Id;
        public int studentId;
        public string Town;
        public int HouseNumber;

        public StudentuAdresas(int aId, int aStudentId, string aTown,int aHouseNumber)
        {
            Id = aId;
            studentId = aStudentId;
            Town = aTown;
            HouseNumber = aHouseNumber;
        }
    }
}
