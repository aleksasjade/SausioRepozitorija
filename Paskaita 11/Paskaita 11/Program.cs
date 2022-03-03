using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Skaicius skaiciu1Obj = new Skaicius(13);

            Console.WriteLine(skaiciu1Obj.Prideti(10));
            Console.WriteLine(skaiciu1Obj.Atimti(10));
            Console.WriteLine(skaiciu1Obj.Padauginti(10));
            Console.WriteLine(skaiciu1Obj.Padalinti(10));
            Console.WriteLine(skaiciu1Obj.PakeltiKvadratu());
            Console.WriteLine(skaiciu1Obj.PakeltiKubu());

            Console.ReadLine();
        }
    }
}
