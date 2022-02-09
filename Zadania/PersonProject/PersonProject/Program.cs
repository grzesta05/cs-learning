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
            TeamManager teamManager = new TeamManager(10,"01-sty-2012","Manager","1", "01-sty-1990", "12312312312", Sex.Other, "123123123");
            Team team = new Team("Grupa 1", teamManager);
            for(int i = 0; i < 10; i++)
            {
                TeamMember member = new TeamMember("01-sty-2000", "Worker", $"Person{i+1}","Surname","01-sty-1980", $"1231231231{i}",Sex.Other, "123123123");
                team.addMember(member);
            }
            Team.SaveXML("serialize", team);
        }

    }
}
