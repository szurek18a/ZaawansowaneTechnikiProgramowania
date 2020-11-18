using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad606
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int i=0; i<t; i++)
            {
                string liczby = Console.ReadLine();
                liczby = liczby.Substring(2);               
                object[] tab = liczby.Split(' ');

                for(int j=tab.Length - 1; j>=0; j--)
                {
                    Console.Write(tab[j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}