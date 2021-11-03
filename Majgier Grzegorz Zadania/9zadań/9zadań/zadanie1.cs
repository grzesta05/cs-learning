using System;
using System.Collections.Generic;
using System.Text;

namespace _9zadań
{
    class zadanie1
    {

        public static void z1()
        {
            float x = float.Parse(Console.ReadLine());
            decimal y = Decimal.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round((decimal)x+y,2));
            Console.WriteLine(Math.Round((decimal)x-y,2));
            Console.WriteLine(Math.Round((decimal)x*y,2));
            Console.WriteLine(Math.Round((decimal)x/y,2));
        }
    }
}
