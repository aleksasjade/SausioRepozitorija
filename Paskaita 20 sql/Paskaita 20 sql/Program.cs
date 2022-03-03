using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_20_sql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();

            database.IrasytiDuomenis(15,"PEtrauskas","Petras",6.6,"Jonava");

            


            Console.ReadLine();
        }
    }
}
