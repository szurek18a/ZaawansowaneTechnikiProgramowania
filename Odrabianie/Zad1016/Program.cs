using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1016
{
    class Program
    {
        static void Main(string[] args)
        {
			{
				int t;
				t = int.Parse(Console.ReadLine());
				for (int i = 0; i < t; ++i)
				{
					int v1, v2;
					string[] text = Console.ReadLine().Split();
					v1 = int.Parse(text[0]);
					v2 = int.Parse(text[1]);
					Console.WriteLine(2 * (v1 * v2) / (v1 + v2));
				}
			}
		}
    }
}
