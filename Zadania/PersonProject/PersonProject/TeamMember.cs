using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProject
{
    sealed class TeamMember : Person
    {
        public DateTime signingTime;
        public string function;
        public TeamMember(string signingTime, string function, string name, string surname, string DateOfBirth, string socialid, Sex sex, string phoneNum) : base(name, surname, DateOfBirth,socialid,sex,phoneNum)
        {
            DateTime.TryParseExact(signingTime, new[] { "yyyy-MM-dd", "yyyy/MM/dd", "MM/dd/yy", "dd-MMM-yy", "dd-MM-yyyy" }, null, System.Globalization.DateTimeStyles.None, out this.signingTime);
            this.function = function;
        }
        new public void ToString()
        {
            base.ToString();
            Console.WriteLine(" " + this.signingTime.ToShortDateString() + " " + this.function);    
        }
    }
}
