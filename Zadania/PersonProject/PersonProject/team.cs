using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProject
{
    class Team
    {
        private int membersCount;
        private string name;
        private TeamManager manager;
        private List<TeamMember> members;

        //Constructors, setters and getters
        public Team() 
        {
            membersCount = 0;
            name = null;
            manager = null;
            members = new List<TeamMember>();
        }

        public Team(string name, TeamManager manager) : this()
        {
            
            this.name = name;
            this.manager = manager;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public TeamManager Manager
        {
            get { return manager; }
            set { manager = value; }
        }
        //Methods
        public void addMember(TeamMember member)
        {
            members.Add(member);
            membersCount++;
        }
        public override string ToString()
        {
           StringBuilder sb = new StringBuilder();
            //Team name, manager and members count
            sb.AppendLine($"Team Name: {name}");
            sb.AppendLine($"Manager: {manager.Name} {manager.Surname}");
            sb.AppendLine($"Members count: {membersCount}");
            foreach(TeamMember member in members)
            {
                sb.AppendLine($"{member.Name} {member.Surname}");
            }
            return sb.ToString();
        }
        public void deleteMember(string socialid)
        {
            foreach(TeamMember member in members)
            {
                if(member.isSocialId(socialid))
                {
                    membersCount--;
                    members.Remove(member);
                    break;
                }
            }
        }
        public List<TeamMember> findMembers(string function)
        {
            return members.FindAll(delegate (TeamMember member)
            {
                return member.function == function;
            });
        }
        public List<TeamMember> findMembers(int month)
        {
            return members.FindAll(delegate (TeamMember member)
            {
                return member.signingTime.Date.Month == month;
            });
        }

        public void deleteAllMembers()
        {
            members.Clear();
            membersCount = 0;
        }
        public void deleteMember(string name, string surname)
        {
            foreach (TeamMember member in members)
            {
                if (member.Name == name && member.Surname == surname)
                {
                    membersCount--;
                    members.Remove(member);
                    break;
                }
            }
        }
        public bool isMember(string socialid)
        {
            foreach(TeamMember member in members)
            {
                if(member.isSocialId(socialid))
                    return true;
            }
            return false;
        }
        public bool isMember(string name, string surname)
        {
            foreach (TeamMember member in members)
            {
                if (member.Name == name && member.Surname == surname)
                    return true;
            }
            return false;
        }
    }
}
