using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad498
{
    class Program
    {
        static int getLengthlcs(string word1, string word2)
        {
            int max =0;
            int len1, len2;
            len1 = word1.Length;
            len2 = word2.Length;
            int[,] matrix = new int [1001, 1001];

            for(int j=0; j<len1; j++)
            {
                for(int k=0; k<len2; k++)
                {
                    if(word1[j] == word2[k])
                    {
                        matrix[j+1, k+1] = 1 + matrix[j, k];
                    }
                    else
                    {
                        max = matrix[j+1, k];
                        if(matrix[j, k+1] > max)
                            max = matrix[j, k+1];
                        matrix[j+1, k+1] = max;
                    }
                }
            }
            return matrix[len1, len2];
        }

        

        public static void Main()
        {
           int len1, len2, wynik;
           string word1, word2;

           int t = int.Parse(Console.ReadLine());
           
           for(int i = 0; i<t; i++)
           {
                len1 = int.Parse(Console.ReadLine());
                word1 = Console.ReadLine();
                len2 = int.Parse(Console.ReadLine());
                word2 = Console.ReadLine();

                wynik = getLengthlcs(word1, word2);
                Console.WriteLine(wynik);
           }
        }
    }
}
