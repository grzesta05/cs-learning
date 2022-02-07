﻿using System;
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
            Team it = new Team("Grupa IT2", a);
            for(int i=0;i<10;i++)
            {
                TeamMember member = new TeamMember("01-01-2020", "programmer", "Adam", "Rwryw", "02-03-2000", $"{i}1231{i}312311", Sex.Man, "123123123");
                
                it.addMember(member);
              
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
            Team s =(Team) it.Clone();
            Team.SaveXML("serialize.xml", s);

            Team f = Team.ImportXML("serialize.xml");

            Console.WriteLine(f.members[0]);
            Console.ReadKey();
        }

    }
}
