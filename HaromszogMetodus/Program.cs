using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace haromszog
{
    class Program
    {
        static int Kerulet(int x1, int x2, int x3)
        {
            return x1 + x2 + x3;
        }

        static double Terulet(int x1, int x2, int x3)
        {
            double s = (x1 + x2 + x3) / 2;

            s = s * (s - x1) * (s - x2) * (s - x3);

            return Math.Sqrt(s);

        }
        static void Main(string[] args)
        {
            int a, b, c, ker;
            double ter;

            Console.Write("Kerem az \"a\" oldlalt: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kerem az \"b\" oldlalt: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kerem az \"c\" oldlalt: ");
            c = Convert.ToInt32(Console.ReadLine());

            ter = Terulet(a, b, c);
            ker = Kerulet(a, b, c);

            Console.WriteLine("A kerulet: {0}", ker);
            Console.WriteLine("A terulet: {0:N2}", ter);

            Console.ReadKey();
        }
    }
}
