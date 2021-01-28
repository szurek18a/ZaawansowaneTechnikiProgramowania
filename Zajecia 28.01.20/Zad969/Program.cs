using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad969
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers;
            while ((numbers = Console.ReadLine()) != null)
            {
                string[] tmp = numbers.Split(' ');
                float a = float.Parse(tmp[0]);
                float b = float.Parse(tmp[1]);
                float c = float.Parse(tmp[2]);

                float delta = b * b - 4 * a * c;
                if (delta > 0)
                    Console.WriteLine("2");
                else if (delta == 0)
                    Console.WriteLine("1");
                else Console.WriteLine("0");
            }
        }
    }
}
