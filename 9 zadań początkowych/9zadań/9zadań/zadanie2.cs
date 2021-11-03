using System;
using System.Collections.Generic;
using System.Text;

namespace _9zadań
{
    class zadanie11
    {
        public static void z2()
        {
            int sum = 0;
            int[] tab = new int[10];
            foreach(int i in tab)
            {   
                tab[i] = int.Parse(Console.ReadLine());
                sum += (tab[i] % 3 ==0 || tab[i] % 5 == 0 ?  tab[i] : 0 );
            }
            Console.WriteLine($"Suma to: {sum}, a średnia to {(double)sum/10}");
        }
    }
}
