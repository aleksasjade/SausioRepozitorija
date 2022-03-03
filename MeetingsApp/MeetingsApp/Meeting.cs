using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingsApp
{
    internal class Meeting
    {
        public string name;
        public ResponsiblePerson responsiblePerson;
        public string description;
        public Category category;
        public MeetingType type;
        public DateTime startDate;
        public DateTime endDate;
        public List<string> peopleInTheMeeing = new List<string>();



        public Meeting(string aName, ResponsiblePerson aResponsiblePerson, string aDescription, Category aCategory, MeetingType aType, DateTime aStartDate, DateTime aEndDate)
        {
            name = aName;
            responsiblePerson = aResponsiblePerson;
            description = aDescription;
            category = aCategory;
            type = aType;
            startDate = aStartDate;
            endDate = aEndDate;
        }

        public void Info()
        {
            Console.WriteLine($"Meeting name: {name}");
            Console.WriteLine($"Meeting responsible person: {responsiblePerson.GetName()}");
            Console.WriteLine($"Meeting description: {description}");
            Console.WriteLine($"Meeting category: {category}");
            Console.WriteLine($"Meeting type: {type}");
            Console.WriteLine($"Meeting start date: {startDate.ToString()}");
            Console.WriteLine($"Meeting end date: {endDate.ToString()}");
            TimeSpan span = endDate.Subtract(startDate);
            Console.WriteLine($"Meeting duration {span}");
            Console.Write("People in this meeting: ");
            foreach (var person in peopleInTheMeeing)
            {
                Console.Write($"{person} ");
            }
            Console.WriteLine();
        }

        public void AddPersonToMeeting(string personName)
        {
            peopleInTheMeeing.Add(personName);
        }
    }
}
