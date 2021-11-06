using System;
using System.Collections.Generic;
using System.Text;

namespace _9zadań
{
    class zadanie8
    {
        static public int euklides(int a, int b)
        {
            if (b == 0)
               return a;
            else
               return euklides(b, a%b);
        }
        static public void z8()
        {
            Console.WriteLine("Podaj a i b");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(euklides(a,b));
        }
    }
}
