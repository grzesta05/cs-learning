using System;
using System.Collections.Generic;
using System.Text;

namespace _9zadań
{
    class zadanie2
    {
        public static void z2()
        {
            int y = int.Parse(Console.ReadLine());
            int x = y;
            while(x > 0)
            {
                if(x%10 == 3)
                {
                    Console.WriteLine($"liczba {y} zawiera cyfrę 3");
                    break;
                }
                else
                {
                    x = x / 10;
                }
            }
            if(x<=0)
                Console.WriteLine($"{y} nie zawiera 3");
        }
    }
}
