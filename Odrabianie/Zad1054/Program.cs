using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1054
{
    class Program
    {
        static void Main(string[] args)
        {
            int domy = int.Parse(Console.ReadLine());
            int a, b, c;
            int x, y, z;

            string[] liczby = Console.ReadLine().Split();
            int row1 = int.Parse(liczby[0]);
            int row2 = int.Parse(liczby[1]);
            int row3 = int.Parse(liczby[2]);
            
            for (int i = 2; i <= domy; i++)
            {
                string[] liczby2 = Console.ReadLine().Split();
                a = int.Parse(liczby2[0]);
                b = int.Parse(liczby2[1]);
                c = int.Parse(liczby2[2]);

                x = a + Math.Min(row2, row3);
                y = b + Math.Min(row1, row3);
                z = c + Math.Min(row1, row2);

                row1 = x;
                row2 = y;
                row3 = z;
            }
            Console.WriteLine(Math.Min(row1, (Math.Min(row2, row3))));
        }
    }
}
