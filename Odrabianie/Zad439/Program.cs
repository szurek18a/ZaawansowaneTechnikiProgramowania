using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Zad439
{
    class Program
    {
        static void Main(string[] args)
        {
			int n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{							
				string[] text = Console.ReadLine().Split();
				var l1 = BigInteger.Parse(text[0]);
				var l2 = BigInteger.Parse(text[1]);

				var wynik = BigInteger.Multiply(l1, l2);

				Console.WriteLine(wynik.ToString());
			}		
		}
    }
}
