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
            Team it = new Team("Grupa IT", a);
            for(int i=0;i<10;i++)
            {
                TeamMember member = new TeamMember("01-01-2020", "programmer", $"Adam", "Rwryw", "02-03-2000", $"{i}1231{i}312311", Sex.Man, "123123123");
                TeamMember member1 = new TeamMember("01-01-2020", "programmer", $"BAdam", "Aywryw", "02-03-2000", "12312312311", Sex.Man, "123123123");
                TeamMember member2 = new TeamMember("01-01-2020", "programmer", $"Sadam", "Rywryw", "02-03-2000", "12312312311", Sex.Man, "123123123");
                it.addMember(member);
                it.addMember(member1);
                it.addMember(member2);
            }
            Team it2 = (Team)it.Clone();
            if(ReferenceEquals(it, it2))
            {
                Console.WriteLine("Fail");
            }
            else
            {
                Console.WriteLine("Success");
            }
            it.SortBySocialID();
            Console.WriteLine(it.ToString());
            Console.ReadKey();
        }

    }
}
