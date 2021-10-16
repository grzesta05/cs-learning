using System;
using System.Collections.Generic;
using System.Text;

namespace _9zadań
{
    class zadanie5
    {
        static private string compression(string inp)
        {
            char[] text = inp.ToCharArray();
            inp = "";
            int count = 1;
            for(int i = 1; i < text.Length; i++)
            {
              
                
                if(text[i-1] == text[i])
                {
                    count++;
                    

                }
                else
                {
                    inp += $"{text[i-1]}{count}";
                    count = 1;
                }
                if (i == text.Length - 1)
                {
                    inp += $"{text[i]}{count}";
                }


            }
            return inp;

        }
        static public void z5()
        {
            Console.WriteLine("Podaj tekst do kompresji");
            string input = Console.ReadLine();
            Console.WriteLine(compression(input));
        }
    }


    
}
