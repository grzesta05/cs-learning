using System;
using System.Collections.Generic;
using System.Text;

namespace _9zadań
{
    
    class zadanie8plus
    {
        static public int dwumian(int n, int k)
        {
            if (k == 0 || n == k)
                return 1;
            return dwumian(n - 1, k - 1) + dwumian(n - 1, k);
        }
        static public void z8plus()
        {
            Console.WriteLine("Dwumian Newtona. Podaj n i k");
            int n =int.Parse(Console.ReadLine());
            int k =int.Parse(Console.ReadLine());
            if(k > n)
            {
                Console.WriteLine("Zamieniono n i k, bo podano złe dane");
                int i = k;
                k = n;
                n = i;
            }
            Console.WriteLine(dwumian(n,k));
           
        }
    }
}
