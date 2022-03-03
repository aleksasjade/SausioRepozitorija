using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] masyvas = new int[3];
                int test = Convert.ToInt32(Console.ReadLine());
                masyvas[5] = test;
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message); 
            }
        }
    }
}
