using System;
using System.Linq;

namespace triangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input 1st triangle side:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input 2nd triangle side:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input 3rd triangle side:");
            int c = Convert.ToInt32(Console.ReadLine());
            int[] i = { a, b, c };
            int maxvalue = i.Max();
            int a1 = a * a;
            int b1 = b * b;
            int c1 = c * c;
            if (a == b && b == c && a == c)
                Console.WriteLine("Triange is равносторонний");
            else if ((a == maxvalue) && (a1 == (b1 + c1)))
                Console.WriteLine("Triangle is прямоугольный");
            else if ((b == maxvalue) && (b1 == (a1 + c1)))
                Console.WriteLine("Triangle is прямоугольный");
            else if ((c == maxvalue) && (c1 == (a1 + b1)))
                Console.WriteLine("Triange is прямоугольный");
            else if (a == b || b == c || a == c)
                Console.WriteLine("Triange is равнобедренный");
        }
    }
}
