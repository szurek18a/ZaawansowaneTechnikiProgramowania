using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad522
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for(int i=0; i < N; i++)
            {
                string tekst = Console.ReadLine();
                string[] tekstTab = tekst.Split(' ');
                int mniejsza = int.Parse(tekstTab[0]);
                int wieksza = int.Parse(tekstTab[1]);
                int tmp;
                if(mniejsza > wieksza)
                {
                    tmp = mniejsza;
                    mniejsza = wieksza;
                    wieksza = tmp;
                }
                int wynik = wieksza;
                while (wynik%mniejsza != 0 || wynik % wieksza != 0)
                {
                    wynik += wieksza;
                }
                Console.WriteLine(wynik);
            }
        }
    }
}
