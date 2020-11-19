using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad619
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string result = Convert(float.Parse(Console.ReadLine()));
                string[] tab = result.Split('-');

                result = "";

                for (int j = tab.Length - 1; j >= 0; j--)
                {
                    if (tab[j][0] == '0')
                    {
                        result += tab[j][1];
                    }
                    else
                    {
                        result += tab[j];
                    }
                    if(j > 0)
                    {
                        result += " ";
                    }
                }
                Console.WriteLine(result.ToLower());
            }
        }

        private static string Convert(float v)
        {
            return BitConverter.ToString(BitConverter.GetBytes(v));
        }
    }
}
