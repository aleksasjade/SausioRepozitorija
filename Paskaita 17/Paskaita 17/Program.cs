using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UnitController<Enemy> enemy = new UnitController<Enemy>();
            UnitController<Hero> hero = new UnitController<Hero>();

            enemy.Print();
            hero.Print();


            Console.ReadLine();

        }

        private static void Studentas()
        {
            List<Studentas> studentai = new List<Studentas>()
            {
                new Studentas(0, "Tomas",18,8.3, true),
                new Studentas(1, "Petras",19,8.7, false),
                new Studentas(2, "Jurgis",14,9.9, true),
                new Studentas(3, "Ona",23,10, true),
                new Studentas(4, "Kamile",25,4.3, false),
                new Studentas(5, "Ruta",17,3.7, false),
                new Studentas(6, "Aleksas",15,5.3, false)
            };

            var filtras20 = studentai.FindAll(studentas => studentas.age >= 20);

            Console.Write("Gali gerti alko: ");
            foreach (var item in filtras20)
            {
                Console.Write($"{item.name}({item.age}) ");
            }

            Console.WriteLine();

            var filtrasGaunaParamaVidurkisDaugiau8 = studentai.FindAll(studentas => studentas.averageMark >= 8 && studentas.isGettingTuition);

            Console.Write("Gauna parama ir vidurkis daugiau uz 8: ");
            foreach (var item in filtrasGaunaParamaVidurkisDaugiau8)
            {
                Console.Write($"{item.name}({item.averageMark})({item.isGettingTuition}) ");
            }

            Console.WriteLine();

            var filtrasVIdurkisIki4irVardas8Maziau = studentai.FindAll(studentas => studentas.name.Length < 8 && studentas.averageMark < 4);

            Console.Write("Vidurkis <4 ir vardo ilgis <=8: ");
            foreach (var item in filtrasVIdurkisIki4irVardas8Maziau)
            {
                Console.Write($"{item.name}({item.averageMark}) ");
            }

            Console.ReadLine();
        }
    }
}
