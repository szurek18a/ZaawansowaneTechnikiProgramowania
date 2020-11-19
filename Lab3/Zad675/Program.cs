using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad675
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int[] skarb = new int[2];
                int n = int.Parse(Console.ReadLine());
                for(int j = 0; j < n; j++)
                {
                    string[] tab = Console.ReadLine().Split(' ');
                    int kier = int.Parse(tab[0]);
                    int kroki = int.Parse(tab[1]);
                    switch (kier)
                    {
                        case 0:
                            skarb[0] += kroki; 
                            break;
                        case 1:
                            skarb[0] -= kroki;
                            break;
                        case 2:
                            skarb[1] += kroki;
                            break;
                        case 3:
                            skarb[1] -= kroki;
                            break;
                    }
                    
                }
                if (skarb[0] != 0 || skarb[1] != 0)
                {
                    if (skarb[0] > 0) //POLNOC POLUDNIE
                        Console.WriteLine("0 " + skarb[0]);
                    else if (skarb[0] < 0)
                        Console.WriteLine("1 " + Math.Abs(skarb[0]));

                    if (skarb[1] > 0) //WSCHOD ZACHOD
                        Console.WriteLine("2 " + skarb[1]);
                    else if (skarb[1] < 0)
                        Console.WriteLine("3 " + Math.Abs(skarb[1]));

                }
                else
                {
                    Console.WriteLine("studnia");
                }
            }
        }
    }
}
