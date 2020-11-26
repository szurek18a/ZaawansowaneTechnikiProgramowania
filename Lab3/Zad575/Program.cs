using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad575
{
    class Program
    {       
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            
            List <int> liczbyZnaczace = new List<int>();
            for(int i=2; i<=Math.Sqrt(1000000000); i++)
            {
                if(czyPierwsza(i)==true)
                    liczbyZnaczace.Add(i*i);
                
                    
            }
            while(t > 0)
            {
                string[] liczby = Console.ReadLine().Split(' ');
                int a = int.Parse(liczby[0]);
                int b = int.Parse(liczby[1]);

                int licznik = 0;
                for(int i=0; i<liczbyZnaczace.Count; i++)
                {
                    if (liczbyZnaczace[i] >= a && liczbyZnaczace[i] <= b)
                        licznik++;
                    if(liczbyZnaczace[i]>b)
                        break;
                }
                Console.WriteLine(licznik);
                t--;
            }
        }

        static bool czyPierwsza(int a)
        {
            for(int i=2; i<= Math.Sqrt(a); i++)
            {
                if(a%i == 0)
                {
                    return false;
                }
            }
            return true;
        }
       
    }
}
