using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace baitap6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Input the first number to multiply: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the second number to multiply: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the third number to multiply: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double d = a * b * c;

            Console.WriteLine("{0} x {1} x {2} = {3}",a,b,c,d);
        }
    }
}