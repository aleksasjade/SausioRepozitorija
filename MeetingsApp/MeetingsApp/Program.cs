using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MeetingsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Meeting> meetingList = new List<Meeting>(JsonToAList());


            bool askForAction = true;
            while (askForAction)
            {
                try
                {
                    Console.WriteLine("\nChoose an action:\n 1. Create a new meeting\n 2. List all meetings\n 3. Add a person to the meeting\n 4. Remove a person from a meeting\n 5. Delete a meeting\n 6. Save and exit");
                    int choiseOfAction = Convert.ToInt32(Console.ReadLine());
                    if (choiseOfAction == 1)
                    {
                        Meeting meeting = CreateMeeting();
                        meetingList.Add(meeting);
                        Console.WriteLine("Meeting created succesfully!");
                    }
                    else if (choiseOfAction == 2)
                    {
                        FilterOptions(meetingList);
                    }
                    else if (choiseOfAction == 3)
                    {
                        AddAPersonToMeeting(meetingList);
                    }
                    else if (choiseOfAction == 4)
                    {
                        RemoveAPersonFromMeeting(meetingList);
                    }
                    else if (choiseOfAction == 5)
                    {
                        DeleteAMeeting(meetingList);
                    }
                    else if (choiseOfAction == 6)
                    {
                        askForAction = false;
                        Console.WriteLine("Goodbye!");
                    }
                    else
                    {
                        Console.WriteLine("Wrong choise. Try again.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Invalid choise. Try again. {ex.Message}");
                }

            }
            string json = JsonConvert.SerializeObject(meetingList, Formatting.Indented);
            File.WriteAllText(@"MeetingsFile.json", json);

            Console.ReadLine();
        }

        public static Meeting CreateMeeting()
        {
            Console.WriteLine("\nMeeting creation:");
            string name = AskForName();
            ResponsiblePerson responsiblePerson = AskForRespoinsiblePerson();
            string description = AskForDescription();
            Category category = AskForCategory();
            MeetingType meetingType = AskForMeetingType();
            DateTime startDate = AskForStartDate();
            DateTime endDate = CheckEndDate(startDate);

            Console.WriteLine();

            Meeting meeting = new Meeting(name, responsiblePerson, description, category, meetingType, startDate, endDate);

            return meeting;
        }

        public static string AskForName()
        {
            Console.Write("Meeting name: ");
            string name = Console.ReadLine();
            return name;
        }
        public static ResponsiblePerson AskForRespoinsiblePerson()
        {
            Console.Write("Responsible person: ");
            ResponsiblePerson responsiblePerson = new ResponsiblePerson(Console.ReadLine());
            return responsiblePerson;
        }

        public static string AskForDescription()
        {
            Console.Write("Meeting description: ");
            string description = Console.ReadLine();
            return description;
            //c
        }

        public static Category AskForCategory()
        {
            Category category = Category.CatchUp;
            bool chooseCategory = true;
            while (chooseCategory)
            {
                Console.Write("Meeting category: \n 1. CatchUp\n 2. Training\n 3. Short\n 4. TeamBuilding\n");
                string categoryChoice = Console.ReadLine();

                switch (categoryChoice)
                {
                    case "1":
                        category = Category.CatchUp;
                        chooseCategory = false;
                        break;
                    case "2":
                        category = Category.Training;
                        chooseCategory = false;
                        break;
                    case "3":
                        category = Category.Short;
                        chooseCategory = false;
                        break;
                    case "4":
                        category = Category.TeamBuilding;
                        chooseCategory = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        continue;
                }
            }
            return category;
        }

        public static MeetingType AskForMeetingType()
        {
            MeetingType meetingType = MeetingType.Remote;
            bool chooseType = true;


            while (chooseType)
            {
                Console.Write("Meeting category: \n 1. Remote\n 2. InPerson\n");
                string typeChoice = Console.ReadLine();

                switch (typeChoice)
                {
                    case "1":
                        meetingType = MeetingType.Remote;
                        chooseType = false;
                        break;
                    case "2":
                        meetingType = MeetingType.InPerson;
                        chooseType = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        continue;
                }
            }
            return meetingType;
        }

        public static DateTime AskForStartDate()
        {
            DateTime startDate = new DateTime(0);
            while (true)
            {
                try
                {
                    Console.Write("Meeting start date and time (yyyy/mm/dd hh:mm) ");
                    startDate = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong start date format. Try again.");
                }
            }
            return startDate;

        }

        public static DateTime AskForEndDate()
        {
            DateTime endDate = new DateTime(0);
            while (true)
            {
                try
                {
                    Console.Write("Meeting end date and time (yyyy/mm/dd hh:mm) ");
                    endDate = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong end date format. Try again.");
                }
            }

            return endDate;
        }

        public static DateTime CheckEndDate(DateTime startDate)
        {
            DateTime endDate = new DateTime(0);
            bool dateIsCorrect = false;
            while (!dateIsCorrect)
            {
                endDate = AskForEndDate();
                TimeSpan span = endDate.Subtract(startDate);
                if (span.TotalSeconds > 0)
                {
                    dateIsCorrect = true;
                }
                else
                {
                    Console.WriteLine("End date cannot be earlier than start date. Try again.");
                }
            }
            return endDate;
        }

        public static List<Meeting> JsonToAList()
        {
            List<Meeting> meetingList = new List<Meeting>();
            try
            {
                using (StreamReader r = new StreamReader("MeetingsFile.json"))
                {
                    string json1 = r.ReadToEnd();
                    meetingList = JsonConvert.DeserializeObject<List<Meeting>>(json1);
                }
            }
            catch (Exception)
            {

            }
            return meetingList;
        }

        public static void DeleteAMeeting(List<Meeting> meetingList)
        {
            Console.WriteLine("Choose a meeting to delete: ");
            for (int i = 0; i < meetingList.Count; i++)
            {
                int meetingOrder = i + 1;
                Console.WriteLine($"{meetingOrder.ToString()}. {meetingList[i].name}");

            }
            int meetingNumber = Convert.ToInt32(Console.ReadLine());

            if (meetingNumber < 1 || meetingNumber > meetingList.Count)
            {
                Console.WriteLine("Wrong choise. Try again.");
            }
            else
            {
                Console.Write("Enter your name: ");
                string nameEntered = Console.ReadLine();
                if (meetingList[meetingNumber - 1].responsiblePerson.Name.ToLower() == nameEntered.ToLower())
                {
                    meetingList.RemoveAt(meetingNumber - 1);
                    Console.WriteLine("Meeting deleted");
                }
                else if (meetingList[meetingNumber - 1].responsiblePerson.Name.ToLower() != nameEntered.ToLower())
                {
                    Console.WriteLine("You are not resposible for this meeting. Meeting deletion failed.");
                }
                else
                {
                    Console.WriteLine("Wrong choise. Try again.");
                }
            }
        }

        public static void AddAPersonToMeeting(List<Meeting> meetingList)
        {
            Console.WriteLine("Choose a meeting to add a person to: ");
            for (int i = 0; i < meetingList.Count; i++)
            {
                int meetingOrder = i + 1;
                Console.Write($"{meetingOrder.ToString()}. {meetingList[i].name}");
                Console.Write(" (People in this meeting: ");
                foreach (var person in meetingList[i].peopleInTheMeeing)
                {
                    Console.Write($"{person}, ");
                }
                Console.WriteLine(")");
            }
            int meetingNumber = Convert.ToInt32(Console.ReadLine());
            if (meetingNumber > 0 && meetingNumber <= meetingList.Count)
            {
                Console.Write($"Enter a person to add to {meetingList[meetingNumber - 1].name}: ");
                string nameEntered = Console.ReadLine();

                bool alreadyInThisMeeting = false;
                bool alreadyInAnotherMeetingAtThisTIme = false;

                foreach (var item in meetingList[meetingNumber - 1].peopleInTheMeeing)
                {
                    if (item == nameEntered)
                    {
                        alreadyInThisMeeting = true;
                    }
                }

                foreach (var item in meetingList)
                {
                    foreach (var people in item.peopleInTheMeeing)
                    {
                        if (people == nameEntered)
                        {
                            if (item.startDate < meetingList[meetingNumber - 1].endDate && meetingList[meetingNumber - 1].startDate < item.endDate)
                            {
                                alreadyInAnotherMeetingAtThisTIme = true;
                            }
                        }
                    }
                }

                if (alreadyInThisMeeting)
                {
                    Console.WriteLine($"{nameEntered} is already in this meeting.");

                }
                else if (alreadyInAnotherMeetingAtThisTIme)
                {
                    Console.WriteLine($"{nameEntered} is already in another meeting at this time.");

                }

                if (alreadyInThisMeeting == false && alreadyInAnotherMeetingAtThisTIme == false)
                {
                    meetingList[meetingNumber - 1].AddPersonToMeeting(nameEntered);
                    Console.WriteLine($"{nameEntered} was added to the {meetingList[meetingNumber - 1].name} meeting.");
                }
            }
            else
            {
                Console.WriteLine("Wrong choise. Try again.");
            }
        }

        public static void RemoveAPersonFromMeeting(List<Meeting> meetingList)
        {
            Console.WriteLine("Choose a meeting to remove a person from: ");
            for (int i = 0; i < meetingList.Count; i++)
            {
                int meetingOrder = i + 1;
                Console.Write($"{meetingOrder.ToString()}. {meetingList[i].name}");
                Console.Write(" (People in this meeting: ");
                foreach (var person in meetingList[i].peopleInTheMeeing)
                {
                    Console.Write($"{person}, ");
                }
                Console.WriteLine(")");
            }
            int meetingNumber = Convert.ToInt32(Console.ReadLine());
            if (meetingNumber > 0 && meetingNumber <= meetingList.Count)
            {
                Console.Write($"Enter a person to remove from {meetingList[meetingNumber - 1].name}: ");
                string nameEntered = Console.ReadLine();


                if (meetingList[meetingNumber - 1].peopleInTheMeeing.Count == 0)
                {
                    Console.WriteLine($"{nameEntered} is not in this meeting. This meeting is empty.");
                }
                else
                {
                    bool personInNotInThisMeeting = true;
                    if (nameEntered == meetingList[meetingNumber - 1].responsiblePerson.Name)
                    {
                        Console.WriteLine("You cannot remove responsible person.");
                        personInNotInThisMeeting = false;
                    }
                    else
                    {
                        foreach (var person in meetingList[meetingNumber - 1].peopleInTheMeeing)
                        {
                            if (nameEntered == person)
                            {
                                meetingList[meetingNumber - 1].peopleInTheMeeing.Remove(person);
                                Console.WriteLine($"{person} was removed from {meetingList[meetingNumber - 1].name} meeting.");
                                personInNotInThisMeeting = false;
                                break;
                            }
                        }
                    }
                    if (personInNotInThisMeeting == true)
                    {
                        Console.WriteLine($"{nameEntered} is not in {meetingList[meetingNumber - 1].name} meeting.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Wrong choise. Try again.");
            }
        }
        public static void FilterOptions(List<Meeting> meetingList)
        {
            Console.WriteLine("Choose your filter: \n 1. Show all meetings without filtering\n 2. Filter by description\n 3. Filter by responsible person\n 4. Filter by category\n 5. Filter by type\n 6. Filter by dates\n 7. Filter by the number of attendees\n 8. Exit");
            int filterChoise = Convert.ToInt32(Console.ReadLine());
            if (filterChoise < 1 || filterChoise > 8)
            {
                Console.WriteLine("Invalid choise. Try Again.");
            }
            else if (filterChoise == 1)
            {
                ShowAllMeetings(meetingList);
            }
            else if (filterChoise == 2)
            {
                FilterByDescription(meetingList);
            }
            else if (filterChoise == 3)
            {
                FilterByResponsiblePerson(meetingList);
            }
            else if (filterChoise == 4)
            {
                FilterByCategory(meetingList);
            }
            else if (filterChoise == 5)
            {
                FilterByMeetingType(meetingList);
            }
            else if (filterChoise == 6)
            {
                FilterByDates(meetingList);
            }
            else if (filterChoise == 7)
            {
                FilterByNumberOfAttendees(meetingList);
            }
        }
        public static void ShowAllMeetings(List<Meeting> meetingList)
        {
            foreach (var meeting in meetingList)
            {
                Console.WriteLine();
                meeting.Info();
            }
        }
        public static void FilterByDescription(List<Meeting> meetingList)
        {
            string descriptionFragment = "";
            while (descriptionFragment == "")
            {
                Console.Write($"Enter description or description fragment: ");
                descriptionFragment = Console.ReadLine();
            }

            foreach (var meeting in meetingList)
            {
                if (meeting.description.Contains(descriptionFragment))
                {
                    Console.WriteLine();
                    meeting.Info();
                }
            }
        }
        public static void FilterByResponsiblePerson(List<Meeting> meetingList)
        {
            string responsiblePersonInput = "";
            while (responsiblePersonInput == "")
            {
                Console.Write($"Enter responsible person: ");
                responsiblePersonInput = Console.ReadLine();
            }

            foreach (var meeting in meetingList)
            {
                if (meeting.responsiblePerson.Name == responsiblePersonInput)
                {
                    Console.WriteLine();
                    meeting.Info();
                }
            }
        }
        public static void FilterByCategory(List<Meeting> meetingList)
        {
            Category categoryChoise = AskForCategory();
            foreach (var meeting in meetingList)
            {
                if (meeting.category.Equals(categoryChoise))
                {
                    Console.WriteLine();
                    meeting.Info();
                }
            }
        }
        public static void FilterByMeetingType(List<Meeting> meetingList)
        {
            MeetingType typeChoise = AskForMeetingType();
            foreach (var meeting in meetingList)
            {
                if (meeting.type.Equals(typeChoise))
                {
                    Console.WriteLine();
                    meeting.Info();
                }
            }
        }
        public static void FilterByDates(List<Meeting> meetingList)
        {
            Console.Write("Show meetings starting from ");
            DateTime filterStartDate = AskForStartDate();

            int endDateChoise = 0;
            while (endDateChoise < 1 || endDateChoise > 2)
            {
                Console.WriteLine($"Choose an option below: \n 1. Enter filter end date\n 2. Show meetings starting from {filterStartDate}");
                endDateChoise = Convert.ToInt32(Console.ReadLine());
                if (endDateChoise < 1 || endDateChoise > 2)
                {
                    Console.WriteLine("Invalid choise. Try again.");
                }
            }
            if (endDateChoise == 1)
            {
                Console.Write("Show meetings ending by ");
                DateTime filterSEndDate = CheckEndDate(filterStartDate);
                Console.WriteLine();
                Console.WriteLine($"Meetings between {filterStartDate} and {filterSEndDate}: ");

                foreach (var meeting in meetingList)
                {
                    if (meeting.startDate < filterSEndDate && filterStartDate < meeting.endDate)
                    {
                        Console.WriteLine();
                        meeting.Info();
                    }
                }
            }
            else if (endDateChoise == 2)
            {
                foreach (var meeting in meetingList)
                {
                    if (meeting.startDate > filterStartDate)
                    {
                        Console.WriteLine();
                        meeting.Info();
                    }
                }
            }
        }
        public static void FilterByNumberOfAttendees(List<Meeting> meetingList)
        {
            int numberOfAttendees = -1;
            while (numberOfAttendees < 0)
            {
                Console.Write("Enter minimal number of attendees in a meeting: ");
                numberOfAttendees = Convert.ToInt32(Console.ReadLine());
                if (numberOfAttendees < 0)
                {
                    Console.WriteLine("Number of attendees cannot be negative");
                }
            }
            int numberOfMeetingsWithMoreAttendies = 0;
            foreach (var meeting in meetingList)
            {
                if (meeting.peopleInTheMeeing.Count() >= numberOfAttendees)
                {
                    Console.WriteLine();
                    meeting.Info();
                    numberOfMeetingsWithMoreAttendies++;
                }
            }
            if (numberOfMeetingsWithMoreAttendies == 0)
            {
                Console.WriteLine($"There are no meetings with {numberOfAttendees} attendees or more");
            }
        }
    }
}
