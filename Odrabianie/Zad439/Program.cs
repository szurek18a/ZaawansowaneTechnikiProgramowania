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
			BigInteger product;
			int n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				string[] text = Console.ReadLine().Split();
				long number1 = long.Parse(text[0]);
				long number2 = long.Parse(text[1]);
				
						   
			   product = BigInteger.Multiply(number1, number2);
			   Console.WriteLine(product.ToString());
			   }
		}		
	}
}
