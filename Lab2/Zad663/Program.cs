using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad663
{
    class Program
    {
        static void Main(string[] args)
        {

            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
           
                List<Punkt> list = new List<Punkt>();
                for (int j = 0; j < n; j++)
                {
                    string[] tab = Console.ReadLine().Split(' ');
                    Punkt punkt = new Punkt(tab[0], int.Parse(tab[1]), int.Parse(tab[2]));
                    list.Add(punkt);
                }
                list.Sort();

                foreach (var item in list)
                {
                    Console.WriteLine("{0} {1} {2}", item.Nazwa, item.X, item.Y);
                }
            }
        }
    }

    public class Punkt : IComparable<Punkt>
    {
        public string Nazwa { get; }
        public int X { get; }
        public int Y { get; }
        public double Odleglosc { get; set; }
        public Punkt(string nazwa, int x, int y)
        {
            Nazwa = nazwa;
            X = x;
            Y = y;
            Odleglosc = Math.Sqrt(x * x + y * y);
        }

        public int CompareTo(Punkt other)
        {
            return Odleglosc.CompareTo(other.Odleglosc);
        }
    }
}