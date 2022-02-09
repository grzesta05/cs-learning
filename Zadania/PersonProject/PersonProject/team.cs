using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PersonProject
{
    interface ISaved
    {
        void SaveBinary(string name);
        void ImportBinary(string name);

    }
    [Serializable()]
    sealed public class Team : ICloneable, ISaved
    {
        public int membersCount;
        public string name;
        public TeamManager manager;
        public List<TeamMember> members;

        //Constructors, setters and getters
        public Team()
        {
            membersCount = 0;
            name = null;
            manager = new TeamManager();
            members = new List<TeamMember>();
        }
        public void Initialize(Team a)
        {
            membersCount = a.membersCount;
            name = a.name;
            manager = a.manager;
            members = a.members;

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
            foreach (TeamMember member in members)
            {
                sb.AppendLine($"{member.Name} {member.Surname}");
            }
            return sb.ToString();
        }
        public void deleteMember(string socialid)
        {
            foreach (TeamMember member in members)
            {
                if (member.isSocialId(socialid))
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
            foreach (TeamMember member in members)
            {
                if (member.isSocialId(socialid))
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
        public Object Clone()
        {
            Team temp = new Team(name, manager);
            for (int i = 0; i < membersCount; i++)
            {
                temp.addMember(members[i]);
            }
            return temp;
        }
        public void Sort()
        {
            members.Sort();
        }
        public void SortBySocialID()
        {
            members.Sort(new SocialIDCompare());
        }
        public class SocialIDCompare : IComparer<TeamMember>
        {
            public int Compare(TeamMember a, TeamMember b)
            {
                return a.SocialId.CompareTo(b.SocialId);
            }
        }
        public bool IsMember(TeamMember member)
        {
            return member.Equals(this);
        }

        public void SaveBinary(string name)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream file = new FileStream(name, FileMode.Create);
            try
            {
                binaryFormatter.Serialize(file, this);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        public void ImportBinary(string name)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream file = new FileStream(name, FileMode.Open);
            try
            {
                Team a = (Team) binaryFormatter.Deserialize(file);
                Initialize(a);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
        public static Team ImportXML(string name)
        {
            var XML = new XmlSerializer(typeof(Team));
            using (var file = new FileStream(name+".xml", FileMode.Open))
            {
                return (Team)XML.Deserialize(file);
            }
        }

        public static void SaveXML(string name, Team a)
        {
            using (var stream = new FileStream(name+".xml", FileMode.Create))
            {
                var XML = new XmlSerializer(typeof(Team));
                XML.Serialize(stream, a);
            }
        }
    }
}
