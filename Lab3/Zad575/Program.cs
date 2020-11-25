using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad575
{
    class Program
    {
        static bool CzyZnaczaca(int liczba)
        {
            int suma = 0;
            int licznik = 0;

            for(int i=2; i<Math.Sqrt(liczba); i++)
            {
                if(liczba%i == 0)
                {
                    suma += i;
                    licznik++;
                }
            }

            double srednia = (suma * 1.0) / licznik;
            if (srednia <= Math.Sqrt(liczba))
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            while(t > 0)
            {
                string[] liczby = Console.ReadLine().Split(' ');
                int a = int.Parse(liczby[0]);
                int b = int.Parse(liczby[1]);

                int licznik = 0;
                for(int i=a; i<=b; i++)
                {
                    if (CzyZnaczaca(i))
                        licznik++;
                }
                Console.WriteLine(licznik);
                t--;
            }
        }
    }
}
