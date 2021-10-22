using System;
using System.Collections.Generic;
using System.Text;

namespace _9zadań
{
    
    class zadanie8plus
    {
        static public int silnia(int n, int o)
        {
            if (n <=  1)
                return o;
          
            o *= n;
            return silnia(n-1, o);
        }
        static public void z8plus()
        {
            Console.WriteLine("Dwumian Newtona. Podaj n i k");
            int n =int.Parse(Console.ReadLine());
            int k =int.Parse(Console.ReadLine());
            Console.WriteLine(silnia(n, 1)/(silnia(k,1)*silnia(n-k,1)));
        }
    }
}
