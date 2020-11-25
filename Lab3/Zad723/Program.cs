using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad723
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                Queue<string> kol = new Queue<string>(Console.ReadLine().Split(' '));
                kol.Dequeue();
                var item = kol.Dequeue();
                kol.Enqueue(item);

                foreach (var x in kol)
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
