using System;
using System.Collections.Generic;
using System.Text;

namespace _9zadań
{
    class zadanie33
    {
        public static void z3()
        {
            string input1 = Console.ReadLine();
            char[] tab = input1.ToCharArray();
            string uno = "";
            string dos = "";
            char separator=' ';
            for (int i = 0; i < input1.Length; i++)
            {
               if(!(((int)tab[i] >= 65 && (int)tab[i]<= 90) || ((int)tab[i]>=97 && (int)tab[i]<=122)))
                {
                    separator = tab[i];
                    uno = input1.Substring(0, i);
                    dos = input1.Substring(i+1);
                }
            }
            Console.WriteLine(dos+separator+uno);

        }
    }
}
