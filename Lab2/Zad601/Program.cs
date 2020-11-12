using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad601
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string tekst = Console.ReadLine();
                string[] tekstTab = tekst.Split(' ');
                int a = int.Parse(tekstTab[0]);
                int b = int.Parse(tekstTab[1]);

                Console.WriteLine(nwd(a, b));
            }

        }

        private static int nwd(int a, int b)
        {
            while (b != 0)
            {
                int c = a % b;
                a = b;
                b = c;
            }
            return a;
        }
    }
}