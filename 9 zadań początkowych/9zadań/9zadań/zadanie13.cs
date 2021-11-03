using System;
using System.Collections.Generic;
using System.Text;

namespace _9zadań
{

    class zadanie13
    {

        public static void z13() {
            string b = Console.ReadLine();
            char[] a = b.ToCharArray();
            for(int i = 0; i < a.Length; i++)
            {
                int o = (int)a[i];
                a[i] = (!((o >= 65 && o <= 90) || (o >= 97 && o <= 122)) ?  '\0' : a[i]);
                Console.Write(a[i]);
            }
    }

    }
}
