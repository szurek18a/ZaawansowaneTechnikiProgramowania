using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1609
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int n, pierw;

                n = int.Parse(Console.ReadLine());
                pierw = Convert.ToInt32(Math.Sqrt(n));

                int k = 2;

                while (n > 1 && k <= pierw)
                {
                    while (n % k == 0)
                    {
                        Console.Write(k + " ");
                        n /= k;
                    }
                    ++k;
                }

                if (n > 1)
                    Console.Write(n);

                Console.WriteLine();
            }
        }
    }
}
