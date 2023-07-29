using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tute1.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int batch;

            Console.WriteLine("enter your name :");
            name =Console.ReadLine();
            Console.WriteLine("enter your batch number :");
            batch =int.Parse(Console.ReadLine());
            Console.WriteLine("your name is :"+ name);
            Console.WriteLine("your batch number is :"+ batch);

            Console.WriteLine("input anything to exit :");
            Console.ReadKey();
        }
    }
}
