using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1346
{
    class Program
    {
        static void Main(string[] args)
        {

            string wejscie;
            while (!String.IsNullOrWhiteSpace(wejscie = Console.ReadLine()))
            {
                string haslo = "";

                for (int j = 0; j < 20; j += 2)
                {
                    int tmp = ((int)wejscie[j] - 65) + ((int)wejscie[j + 1] - 65) * 16;

                    haslo += (char)tmp;
                }

                Console.WriteLine(haslo);

            }
            }
    }
}
