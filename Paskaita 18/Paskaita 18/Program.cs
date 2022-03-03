using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paskaita_18.Extensions;

namespace Paskaita_18
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

            var students = studentai.Where(x => x.Age < 25);
            foreach (Studentai student in students)
            {
                Console.WriteLine(student.Name, student.Age);
            }
            Console.ReadLine();
        }



    private static void Ekstensionai()
        {
            int sk = 12;
            Console.WriteLine(sk.PowerTwo());
            Console.ReadLine();
        }
    }
}
