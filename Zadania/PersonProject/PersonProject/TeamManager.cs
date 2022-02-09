using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProject
{
    [Serializable()]
    public class TeamManager : Person, ICloneable 
    {
        public int experience;
        public DateTime signingTime;
        
      public TeamManager()
        {

        }
        public TeamManager(int experience, string signingTime, string name, string surname, string DateOfBirth, string socialid, Sex sex, string phoneNum) : base(name, surname, DateOfBirth, socialid, sex, phoneNum)
        {
            DateTime.TryParseExact(signingTime, new[] { "yyyy-MM-dd", "yyyy/MM/dd", "MM/dd/yy", "dd-MMM-yy", "dd-MM-yyyy" }, null, System.Globalization.DateTimeStyles.None, out this.signingTime);
            this.experience = experience;
        }
        public override string ToString()
        {
            return (base.ToString() + " " + this.signingTime.ToShortDateString() + " " + experience);
            
        }
        public Object Clone()
        {
            TeamManager a = new TeamManager(experience, signingTime.ToString(), Name, Surname, birthDate.ToString(), SocialId, sex, phoneNum);
            return a;
        }

    }
}
