using System;
using System.Collections;
using System.Text;

namespace baitap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            String name = Console.ReadLine();
            Console.WriteLine("Hello: " + name);
            Console.ReadKey();
        }
    }
}