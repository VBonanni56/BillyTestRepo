using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace addition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(num1 + num2);


        }
    }
}