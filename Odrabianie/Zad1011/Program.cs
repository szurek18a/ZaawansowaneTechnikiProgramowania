using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1011
{
    class Program
    {
        static void Main(string[] args)
        {           
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string text = Console.ReadLine();               
                for (int j = 0; j < text.Length/2; j++)
                {
                    Console.Write(text[j]);
                }
                Console.WriteLine();
            }          
        }
    }
}
