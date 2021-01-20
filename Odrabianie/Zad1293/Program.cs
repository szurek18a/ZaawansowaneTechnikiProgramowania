using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Zad1293
{
    class Program
    {
        static void Main(string[] args)
        {			
			int t = int.Parse(Console.ReadLine());
			for (int i = 0; i < t; i++)
			{
				BigInteger a, b;
				string[] text = Console.ReadLine().Split();
				a = BigInteger.Parse(text[0]);
				b = BigInteger.Parse(text[1]);

				Console.WriteLine(a + b);
			}			
		}
    }
}
