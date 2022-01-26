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
        Team()
        {
            membersCount = 0;
            name = null;
            manager = null;
            members = new List<TeamMember>();
        }

        Team(string name, TeamManager manager)
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
        void addMember(TeamMember member)
        {
            members.Add(member);
            membersCount++;
        }
    }
}
