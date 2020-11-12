using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad568
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for(int i=0; i<N; i++)
            {
                int ile = 0;
                string tekst = Console.ReadLine();
                int liczba = int.Parse(tekst);
                int odwrotnie = 0;
                string tekst2 = "";
                do
                {
                    for (int j = tekst.Length - 1; j >= 0; j--)
                    {
                        tekst2 += tekst[j];
                    }
                    odwrotnie = int.Parse(tekst2);
                    if (liczba == odwrotnie)
                    {
                        break;
                    }
                    ile++;
                    liczba += odwrotnie;
                    tekst = liczba.ToString();
                    tekst2 = "";
                } while (true);
                Console.WriteLine(liczba + " " + ile);
            }
        }
    }
}
