using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProject
{
    [Serializable()]
    public class TeamMember : Person, ICloneable, IComparable<TeamMember>
    {
        public DateTime signingTime;
        public string function;

        public TeamMember() : base()
        {

        }
        public TeamMember(string signingTime, string function, string name, string surname, string DateOfBirth, string socialid, Sex sex, string phoneNum) : base(name, surname, DateOfBirth,socialid,sex,phoneNum)
        {
            DateTime.TryParseExact(signingTime, new[] { "yyyy-MM-dd", "yyyy/MM/dd", "MM/dd/yy", "dd-MMM-yy", "dd-MM-yyyy" }, null, System.Globalization.DateTimeStyles.None, out this.signingTime);
            this.function = function;
        }
        public override string ToString()
        {
            return base.ToString() + (" " + this.function);    
        }
        public Object Clone()
        {
            TeamMember a = new TeamMember(signingTime.ToString(), function, Name, Surname, birthDate.ToString(), SocialId, sex, phoneNum);
            return a;
        }
        public int CompareTo(TeamMember a)
        {
            if((int)this.Surname[0] != (int)a.Surname[0])
            {
                return Comparer<string>.Default.Compare(this.Surname, a.Surname);
            }
            else
            {
                return Comparer<string>.Default.Compare(this.Name, a.Name);
            }
        }
    }
}
