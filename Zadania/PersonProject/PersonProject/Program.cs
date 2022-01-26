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
            TeamManager a= new TeamManager(10,"22-12-2021", "CEO","FRFR", "NIW NIW", "01-01-2005", "12312312311", Sex.Man, "505505505");
            a.ToString();
            
            Console.ReadKey();
        }
    }
}
