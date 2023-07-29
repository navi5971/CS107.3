using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tute_1_q_2.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius;
            double area;

            Console.WriteLine("enter the radius :");
            radius = int.Parse(Console.ReadLine());
            Console.WriteLine("the area of a circle is " + (radius * radius * 3.14));
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }
    }
}
