using System;
using System.Collections.Generic;
using System.Text;

namespace _9zadań
{
    class zadanie9
    {
        public static void z9()
        {
            DateTime now = DateTime.Today;
            DateTime endofyear = new DateTime(now.Year, 12, 31);
            Console.WriteLine(endofyear.DayOfYear-now.DayOfYear);
        }
    }
}
