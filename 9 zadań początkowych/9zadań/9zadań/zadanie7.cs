using System;
using System.Collections.Generic;
using System.Text;

namespace _9zadań
{
    class zadanie7
    {
        public static void z7()
        {

            int n = int.Parse(Console.ReadLine());
            int[][] tab = new int[n][];
            for (int i = 0; i < n; i++)
            {
                tab[i] = new int[i];
            }
            for (int i = 0; i < n; i++)
            {
                if (i < 2)
                {
                    for (int p = 0; p < tab[i].Length; p++)
                        tab[i][p] = 1;
                }
                else
                {
                    tab[i][i-1] = 1;
                    tab[i][0] = 1;
                    for (int o = 1; o < i - 1; o++)
                    {
                        tab[i][o] = tab[i - 1][o] + tab[i - 1][o - 1];
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int p = 0; p < i; p++)
                {
                    Console.Write(tab[i][p] + " ");

                }
                Console.WriteLine();
            }
        }
    }
}

