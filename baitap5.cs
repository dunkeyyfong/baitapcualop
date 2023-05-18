using System;
using System.Collections;
using System.Text;

namespace baitap5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a, b, c;
            Console.WriteLine("Input the First Number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Second Number : ");
            b = Convert.ToInt32(Console.ReadLine());

            c = a;
            a = b;
            b = c;

            Console.WriteLine("After Swapping :");
            Console.WriteLine("First Number : " + a);
            Console.WriteLine("Second Number : " + b);

        }
    }
}