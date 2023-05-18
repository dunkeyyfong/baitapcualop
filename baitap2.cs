using System;
using System.Collections;
using System.IO.Pipes;
using System.Text;

namespace baitap2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int num1, num2, sum;
            Console.WriteLine("Input the First number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            Console.WriteLine("The sum of {0} and {1} is {2}", num1, num2, sum);
        }
    }
}