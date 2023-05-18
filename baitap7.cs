using System;
using System.Collections;
using System.Text;

namespace baitap7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Input the first number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the second number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double kq1 = a + b;
            double kq2 = a - b;
            double kq3 = a * b;
            double kq4 = a / b;
            double kq5 = a % b;

            Console.WriteLine("{0} + {1} =  " + kq1, a, b);
            Console.WriteLine("{0} - {1} =  " + kq2, a, b);
            Console.WriteLine("{0} x {1} =  " + kq3, a, b);
            Console.WriteLine("{0} / {1} =  " + kq4, a, b);
            Console.WriteLine("{0} mod {1} =  " + kq5, a, b);
        }
    }
}