using System;
using System.Collections.Generic;
using System.Text;

namespace _9zadań
{
    class zadanie12
    {
        //Napisz metodę Tablica(), który wypełnia n-elementową(n podaje użytkownik) tablicę liczbami całkowitymi z przedziału[-100, 100], 
        //a następnie wypisuje ile jest liczb parzystych, nieparzystych oraz dodatnich i ujemnych.
        public static void Tablica(ref int[] tab,ref int parz,ref int dodatnie)
        {
            Random random = new Random();
            for (int i = 0; i < tab.Length; i++)
            {
               tab[i] = random.Next(-100, 101);
                if (tab[i] % 2 == 0)
                    parz++;
                if (tab[i] >= 0)
                    dodatnie++;
            }
        }
        public static void z12()
        {
            int n = int.Parse(Console.ReadLine());
            int[] tab = new int[n];
            int dod = 0;
            int parz = 0;
            Tablica(ref tab,ref parz,ref dod);
            Console.WriteLine($"Parzyste: {parz} \nNieparzyste: {n-parz} \nDodatnie: {dod} \nUjemne: {n-dod} ");
        }
    }
}
