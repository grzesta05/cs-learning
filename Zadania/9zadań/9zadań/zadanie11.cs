using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace _9zadań
{
    class zadanienr11
    {
        static Double Eval(String expression)
        {
            //Datatable.compute(string 1, string 2); is for forcing literal string calculating 
            System.Data.DataTable table = new System.Data.DataTable();
            return Convert.ToDouble(table.Compute(expression, String.Empty));
        }
        static double Kalkulator(double a, char s, double b)
        {
            string exp = $"{a}{s}{b}";
            return Eval(exp); 
        }
        public static void z11()
        {
            Console.WriteLine("Podaj 1. liczbę");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj znak");
            char s = char.Parse(Console.ReadLine());
            Console.WriteLine("Podaj 2. liczbę");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(a);
            Console.WriteLine(s);
            Console.WriteLine(b);
            Console.WriteLine("==");
            Console.WriteLine(Kalkulator(a,s,b));
        }
    }
}
