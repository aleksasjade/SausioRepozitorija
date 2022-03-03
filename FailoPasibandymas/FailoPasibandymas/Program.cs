using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FailoPasibandymas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Irasykite varda: ");
                string vardas = Console.ReadLine();
                Console.WriteLine("Irasykite amziu: ");
                int amzius = Convert.ToInt32(Console.ReadLine());
                string informacija = $"Jusu vardas yra {vardas}, jums {amzius} metu";

                string fullPath = @"C:\Users\Aleksas\Desktop\C# paskaitos\Projektai\SausioRepozitorija\FailoPasibandymas\FailoPasibandymas\bin\Debug\Failiukas.txt";
                File.WriteAllText(fullPath, informacija);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
