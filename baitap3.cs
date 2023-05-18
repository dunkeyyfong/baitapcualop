using System;
using System.Collections;
using System.Text;

namespace baitap3
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Input the First number: ");
            double so1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the Second number: ");
            double so2 = Convert.ToDouble(Console.ReadLine());
            double kq = so1 / so2;
            Console.WriteLine("the result of dividing {0} and {1} is {2}", so1, so2, kq);
        }
    }
}