﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 

class Program
{
    static void Main()
    {
        // Call method with embedded if-statement three times.
        int result1 = Test(0);
        int result2 = Test(50);
        int result3 = Test(-1);

        // Print results.
        Console.WriteLine(result1);
        Console.WriteLine(result2);
        Console.WriteLine(result3);
    }

    static int Test(int value)
    {
        if (value == 0)
        {
            return -1;
        }
        else if (value <= 10)
        {
            return 0;
        }
        else if (value <= 100)
        {
            return 1;
        }
        else // See note on "else after return"
        {
           
            return 2;
        }
    }
}
 