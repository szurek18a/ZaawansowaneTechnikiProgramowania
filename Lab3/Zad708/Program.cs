using System;

namespace Zad708
{
    class Program
    {
        static int oblicz(int xn, int counter)
        {
            if (xn == 1) return counter;
            else
            {
                counter++;
                if (xn % 2 == 0) 
                    return oblicz(xn / 2, counter); // Parzyste
                else
                    return oblicz(3 * xn + 1, counter); //Nieparzyste
            }
        }
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[t];
            for (int i = 0; i < t; i++)
            {
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine(oblicz(tab[i], 0));
            }
        }
    }
}