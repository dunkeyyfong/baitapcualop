using System;
using System.Text;

namespace baitap8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a,b,c,d;
            double average;
            Console.WriteLine("Enter the First number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the four number: ");
            d = Convert.ToInt32(Console.ReadLine());

            average = (a + b + c + d) / 4;

            Console.WriteLine("The average of {0}, {1}, {2}, {3} is {4}", a, b, c, d, average);
        }
    }
}