using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad727
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            n = int.Parse(Console.ReadLine());
            string str = null;
            for(int i=0; i<n; i++)
            {
                m = int.Parse(Console.ReadLine());
                spare(str, m, 1);
            }           
        }

        static void spare(string s, int l, int min)
        {
            for(int i=min; i <= l/2; i++)
            {
                spare(s + i.ToString()+" ", l-i, i);
            }
            s = s + l.ToString();
            Console.WriteLine(s);
        }
    }
}