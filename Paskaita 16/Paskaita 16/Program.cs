using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_16
{
    public delegate void DoOperation(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            Bankas bankas = new Bankas();
            EmailSender emailSender = new EmailSender();    
            bankas.IvykoTranzakcija += emailSender.SendMessage;
            bankas.IvykoTranzakcija -= (s,e) => emailSender.SendMessage(e);


            bool testi = true;
            while(testi)
            {
                Console.WriteLine("Prideti 1");
                Console.WriteLine("Pervest 2");
                Console.WriteLine("Pakeist 3");
                Console.WriteLine("Iseiti 4");
                int pasirinkimas = Convert.ToInt32(Console.ReadLine());
                switch(pasirinkimas)
                {
                    case 1:
                        Console.WriteLine("Kiek pinigu?");
                        double money = Convert.ToDouble(Console.ReadLine());
                        bankas.PridetiPinigu(money);
                        break;
                    case 2:
                        Console.WriteLine("Kiek pinigu?");
                        double moneyPervesti = Convert.ToDouble(Console.ReadLine());
                        bankas.PervestiPinigu(moneyPervesti, "LT12312323123");
                        break;
                    default:
                        break;
                }
            }
            bankas.PridetiPinigu(50);
            bankas.PervestiPinigu();

            Console.ReadLine();

        }

        private static void Bankas_IvykoTranzakcija(object sender, string e)
        {
            throw new NotImplementedException();
        }

        private static void OPEE()
        {
            DoOperation myDelegate1 = Suma;
            DoOperation myDelegate2 = Sandauga;

            myDelegate1 += myDelegate2;
            myDelegate1(5, 5);


            Console.ReadLine();
        }

        private static void Suma(int a, int b)
        {
            Console.WriteLine($"Suma {a+b}");
        }
        private static void Sandauga(int a, int b)
        {
            Console.WriteLine($"Sandauga {a*b}");
        }

        public static void Uzduotis5()
        {
            try
            {
                Console.WriteLine("Irasykite varda: ");
                string vardas = Console.ReadLine();
                Console.WriteLine("Irasykite amziu: ");
                int amzius = Convert.ToInt32(Console.ReadLine());
                string informacija = $"Jusu vardas yra {vardas}, jums {amzius} metu\n";

                string fullPath = @"C:\Users\Aleksas\VartotojoInfo2.txt";
                File.AppendAllText(fullPath, informacija);

                string infoFailoViduje = File.ReadAllText(fullPath);
                Console.WriteLine(infoFailoViduje);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }


}
