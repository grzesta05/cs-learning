using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProject
{
    sealed class TeamManager : Person, ICloneable 
    {
        public int experience;
        public DateTime signingTime;
        public string function;
        public TeamManager(int experience, string signingTime, string function, string name, string surname, string DateOfBirth, string socialid, Sex sex, string phoneNum) : base(name, surname, DateOfBirth, socialid, sex, phoneNum)
        {
            DateTime.TryParseExact(signingTime, new[] { "yyyy-MM-dd", "yyyy/MM/dd", "MM/dd/yy", "dd-MMM-yy", "dd-MM-yyyy" }, null, System.Globalization.DateTimeStyles.None, out this.signingTime);
            this.function = function;
            this.experience = experience;
        }
        new public void ToString()
        {
            base.ToString();
            Console.Write(" " + this.signingTime.ToShortDateString() + " " + this.function + " " + experience);
        }
        public Object Clone()
        {
            TeamManager a = new TeamManager(experience, signingTime.ToString(), function, Name, Surname, birthDate.ToString(), SocialId, sex, phoneNum);
            return a;
        }

    }
}
