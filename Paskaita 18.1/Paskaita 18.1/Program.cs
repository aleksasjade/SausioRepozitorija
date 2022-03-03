using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_18._1
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


            Console.ReadLine();
        }


        private static void uzduotis()
        {
            List<int> skaiciai = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Visas sarasas: ");
            Console.WriteLine(String.Join(",", skaiciai));
            var nelyginiai = skaiciai.Where(x => x % 2 != 0);
            Console.WriteLine("Nelyginiai: ");
            Console.WriteLine(String.Join(",", nelyginiai));
            var dalinasiIs5 = skaiciai.Where((x) => x % 5 == 0);
            Console.WriteLine("Dalinasi is 5: ");
            Console.WriteLine(String.Join(",", dalinasiIs5));
            bool skaicius7 = skaiciai.Any(x => x == 7);
            Console.WriteLine("Ar yra skaicius 7?");
            Console.WriteLine(String.Join(",", skaicius7));
            bool visiLyginiai = skaiciai.All(x => x % 2 == 0);
            Console.WriteLine("Ar visi lyginiai: ");
            Console.WriteLine(String.Join(",", visiLyginiai));
            bool bentVienasDalinasiIs8 = skaiciai.Any(x => x % 8 == 0);
            Console.WriteLine("Bent vienas dalinasi is 8? ");
            Console.WriteLine(String.Join(",", bentVienasDalinasiIs8));

            List<int> skaiciai2 = new List<int> { 5, 6, 7 };

            var visuKvadratas = skaiciai2.Select(skaicius => skaicius * skaicius);
            Console.WriteLine("Visu kvadratas: ");
            Console.WriteLine(String.Join(",", visuKvadratas));
            var visuSuma = skaiciai2.Sum();
            Console.WriteLine("Visu suma: ");
            Console.WriteLine(String.Join(",", visuSuma));
            var visuVidurkis = skaiciai2.Average();
            Console.WriteLine("Visu vidurkis: ");
            Console.WriteLine(String.Join(",", visuVidurkis));


            Console.ReadLine();
        }
        private static void Studentai(List<Studentai> studentai)
        {
            var students = studentai.Where(x => x.Age < 25);
            foreach (Studentai student in students)
            {
                Console.Write(student.Name);
                Console.Write(" ");
                Console.Write(student.Age);
                Console.WriteLine();
            }

            var result = from s in studentai
                         where s.IsGettingTuition == true
                         select s;

            foreach (Studentai s in result)
            {
                Console.Write(s.Name);
                Console.Write(" ");
                Console.Write(s.IsGettingTuition);
                Console.WriteLine();
            }
        }
    }
}
