using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProject
{
    public enum Sex
    {
        Kobieta,
        Mężczyzna,
        Inne
    }
    class Program
    {

        static void Main(string[] args)
        {
            Person a = new Person("Frfr", "Forfor", "1000-12-12", "11111111111", Sex.Mężczyzna);
            a.Surname = "mickIewIcz";
            Console.WriteLine(a.Age());
            Console.WriteLine(a.Name);
            Console.ReadKey();
        }
    }
}
