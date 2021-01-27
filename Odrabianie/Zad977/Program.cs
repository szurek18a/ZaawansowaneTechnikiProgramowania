using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad977
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tablica = Console.ReadLine().Split(' ');
            List<string> lista = new List<string>(tablica);
            lista.Reverse();
            foreach (string s in lista)
            {
                Console.Write(s + ' ');
            }
        }
    }
}
