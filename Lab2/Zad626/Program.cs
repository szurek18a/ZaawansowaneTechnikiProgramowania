using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad626
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string[] tab = Console.ReadLine().Split(' ');
                int ilu = int.Parse(tab[0]);
                double ile = int.Parse(tab[1]);
                double day = 60 * 60 * 24;
                double zjedli = 0;

                for (int j = 0; j < ilu; j++)
                {
                    zjedli += Math.Floor(day / double.Parse(Console.ReadLine()));
                }
                Console.WriteLine(Math.Ceiling(zjedli / ile));
            }
        }
    }
}