using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Studentai> studentai = new List<Studentai>()
            {
                new Studentai(0,"Tomas",23,9.5,true),
                new Studentai(0,"Jonas",30,7.5,false),
                new Studentai(0,"Petras",22,6.5,false),
                new Studentai(0,"Lina",28,7.5,false),
                new Studentai(0,"Toma",26,5.5,false),
                new Studentai(0,"Juozas",27,7.5,false),
                new Studentai(0,"Goda",31,9.0,true),
            };

            var pagalAverageMark = studentai.OrderBy(x => x.AverageMark);

            foreach (var x in pagalAverageMark)
            {
                Console.Write(x.AverageMark);
                Console.Write(" ");
                Console.WriteLine(x.Name);
            }

            var pagalAmziu = studentai.OrderByDescending(x => x.Age);

            foreach (var x in pagalAmziu)
            {
                Console.Write(x.Age);
                Console.Write(" ");
                Console.WriteLine(x.Name);
            }

            var pagalAgeIrAverageMark = studentai.OrderByDescending(x => x.Age).ThenByDescending(x => x.AverageMark);

            foreach (var x in pagalAgeIrAverageMark)
            {
                Console.Write(x.Age);
                Console.Write(" ");
                Console.Write(x.AverageMark);
                Console.Write(" ");
                Console.WriteLine(x.Name);
            }

            var groupedByAge = studentai.GroupBy(x => x.Age);

            foreach (var x in groupedByAge)
            {
                Console.WriteLine(x.Key);
                foreach (var studentas in x)
                {
                    Console.WriteLine(studentas.Name);
                }
            }

            var groupedIsGettingTuition = studentai.GroupBy(x => x.IsGettingTuition);

            foreach (var group in groupedIsGettingTuition)
            {
                Console.WriteLine(group.Key);
                foreach(var studentas in group)
                {
                    Console.WriteLine(studentas.Name);
                }
            }


            Console.ReadLine();
        }
    }
}
