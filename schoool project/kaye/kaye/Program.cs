using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kaye
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,y;
            Console.WriteLine("enter the number for the multiplication table");
            Console.ReadLine();
            for (x = 1; x <= 12; x++)
            {
                for (y = 1; y <= 12; y++)
                {
                    Console.WriteLine(x * y);
                }

            }
        }
    }
}
