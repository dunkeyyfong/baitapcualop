using System;

namespace baitap9
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            int kq1, kq2;

            Console.WriteLine("Enter first number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            z = Convert.ToInt32(Console.ReadLine());

            kq1 = (x + y) * z;
            kq2 = x * y + y * z;

            Console.WriteLine("Result of specified numbers {0}, {1} and {2}, (x+y).z is {3} and x.y + y.z is {4}", x, y, z, kq1, kq2);
        }
    }
}