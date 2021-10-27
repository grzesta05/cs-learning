using System;
using System.Collections.Generic;
using System.Text;

namespace _9zadań
{
    class zadanie10
    {
        public static void z10()
        {
            Console.WriteLine("Podaj n, dla którego wypisana zostanie figura");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                if (i == 0 || i == n - 1)
                    for (int o = 0; o < n; o++)
                        Console.Write("* ");
                else
                {
                    Console.Write("* ");
                    for (int o = 1; o < n - 1; o++)
                    {
                        if (o == i || o == n - i-1)
                            Console.Write("* ");
                        else
                            Console.Write("  ");
                    }
                    Console.Write("* ");
                }
            }
        }
    }
}
