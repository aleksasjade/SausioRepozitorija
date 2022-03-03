using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingsApp
{
    internal class ResponsiblePerson
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public ResponsiblePerson(string aName)
        {
            name = aName;
        }

        public string GetName()
        {
            return name;
        }
    }
}
