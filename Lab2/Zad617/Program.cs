using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad617
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int i = 0; i < t; i++)
            {
                string[] tekst = Console.ReadLine().Split(' ');
                Console.WriteLine(string_merge(tekst[0], tekst[1]));
            }

        static string string_merge(string a, string b)
        {
            int dlugosc = a.Length < b.Length ? a.Length : b.Length;
            string wynik = "";
            for(int i = 0; i < dlugosc; i++)
            {
                wynik += a[i];
                wynik += b[i];
            }
            return wynik;
        }
    }
    }
}
