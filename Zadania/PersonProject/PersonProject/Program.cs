using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProject
{
    public enum Sex
    {
        Woman,
        Man,
        Other
    }
    class Program
    {

        static void Main(string[] args)
        {
            Person a = new Person("BEaTa", "NOWak", "1992-10-22", "92102201347", Sex.Woman);
            Person b = new Person("JAn", "JanoWski", "1993-03-15", "92031507772", Sex.Man, "50594434");
            a.ToString();
            b.ToString();
            Console.WriteLine(a.hoursLived(8));
            Console.ReadKey();
        }
    }
}
