using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad609
{
    class Program
    {
        static void Main(string[] args)
        {
            string liczby = Console.ReadLine();
            string[] tab = liczby.Split(' ');
            double r = double.Parse(tab[0]);
            double d = double.Parse(tab[1]);
            Console.WriteLine(Oblicz(r, d).ToString().Replace(',','.'));
        }

        private static double Oblicz(double r, double d)
        {
            double pi = 3.141592654;
            double wynik = ((d / 2) * (d / 2) - r * r) * -1;
            return Math.Round(pi * wynik, 2);
        }
    }
}
