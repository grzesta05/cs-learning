using System;
using System.Collections.Generic;
using System.Text;


namespace _9zadań
{
    class zadanie6
    {
        public static void z6()
        {
            
            int[] tab = new int[100];
             for(int i = 0; i < tab.Length; i++)
            {
                Random rand = new Random();
                tab[i] = rand.Next(100);
            }
            for (int o = 0; o < tab.Length-1;o++)
                for (int i = 0; i < tab.Length-o-1; i++)
            {
                if(tab[i] > tab[i+1])
                    {
                        int p = tab[i];
                        tab[i] = tab[i+1];
                        tab[i+1] = p;
                    }
            }
        foreach(int i in tab)
                Console.WriteLine(i);
        }
    }
}
