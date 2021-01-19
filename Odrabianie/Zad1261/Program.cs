using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1261
{
    class Program
    {
        static void Main(string[] args)
        {
            int t, pesel_wynik;
            char[] pesel;
            t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                String str = Console.ReadLine();
                pesel = str.ToCharArray();
                pesel_wynik = (pesel[0] - '0') * 1 + (pesel[1] - '0') * 3 + (pesel[2] - '0') * 7 + (pesel[3] - '0') * 9 + (pesel[4] - '0') * 1 +
                (pesel[5] - '0') * 3 + (pesel[6] - '0') * 7 + (pesel[7] - '0') * 9 + (pesel[8] - '0') * 1 + (pesel[9] - '0') * 3 + (pesel[10] - '0') * 1;
                if (pesel_wynik > 0)
                {
                    if (pesel_wynik % 10 == 0)
                    {
                        Console.WriteLine("D\n");
                    }
                    else
                    {
                        Console.WriteLine("N\n");
                    }
                }
            }
        }
    }
}
