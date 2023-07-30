using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tute_1_q3.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
           

            Console.WriteLine("enter the first number: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number: ");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("the sum is :" +(num1 + num2));
            Console.WriteLine("enter anything to continue");
            Console.ReadKey();

        }
    }
}
