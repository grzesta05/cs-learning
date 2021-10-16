using System;
using System.Collections.Generic;
using System.Text;

namespace _9zadań
{
    class zadanie4
    {
        private static string countingPierw(string sum)
        {
            if(sum.Length == 1)
            {
                return sum;
            }
            char[] tab = sum.ToCharArray();
            int int_sum = 0;
            foreach(char o in tab)
            {
                int_sum += int.Parse(o.ToString());
            }
            sum = int_sum.ToString();
            return countingPierw(sum);

        }
        static public void z4()
        {
            string input = Console.ReadLine();
            Console.WriteLine(zadanie4.countingPierw(input));
        }
    }
}
