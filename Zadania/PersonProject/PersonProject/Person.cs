using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProject
{
     abstract class Person
    {
        //values
        private string name;
        private string surname;
        public string phoneNum { get; set; }
        //Surname and name setters and getters
        public string Surname { 
            get 
            {
                return surname;
            }
            set
            {
                value = value.ToLower();
                char [] i = value.ToCharArray();
                i[0] = Char.ToUpper(i[0]);
                surname = new string(i);

            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                value = value.ToLower();
                char[] i = value.ToCharArray();
                i[0] = Char.ToUpper(i[0]);
                name = new string(i);
            }
        }

        //
        private DateTime birthDate;
        private string SocialId;
        private Sex sex;

        //Constructors
        public Person()
        {
            birthDate = DateTime.Now;
            SocialId = "00000000000";
            name = "Przemek";
            surname = "Generyczny";
            sex = Sex.Other;
        }
        void setName(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public Person(string name, string surname)
        {
            setName(name, surname);
        }
        public Person(string name, string surname, string DateofBirth, string socialid, Sex sex )
        {
            setName(name, surname);
            DateTime.TryParseExact(DateofBirth, new[] { "yyyy-MM-dd", "yyyy/MM/dd", "MM/dd/yy", "dd-MMM-yy", "dd-MM-yyyy" }, null, System.Globalization.DateTimeStyles.None, out birthDate);
            this.sex = sex;
            //            Console.WriteLine("Is Social ID correct: " + isSocialIdCorrect(socialid));
            if (!isSocialIdCorrect(socialid))
            {
                Console.WriteLine("Wrong Social ID!");
            }
            this.SocialId = socialid;
        }
        public Person(string name, string surname, string DateofBirth, string socialid, Sex sex,string phoneNum) : this(name, surname, DateofBirth, socialid, sex)
        {
            this.phoneNum = phoneNum;
        }
        new public void ToString()
        {
            Console.WriteLine($"{Name} {Surname} ({Age()}) {birthDate.ToShortDateString()} {SocialId} {sex} {phoneNum}");
        }
        //Functions
        public bool isSocialId(string socialid)
        {
            return socialid == this.SocialId;
        }
        public int Age()
        {
            DateTime date = new DateTime();
            date = DateTime.Now;
            return (date.Year - birthDate.Year);
        }
        public int hoursLived(int a)
        {
           TimeSpan i = new TimeSpan(DateTime.Now.Ticks - birthDate.Ticks);
            return Convert.ToInt32(i.TotalHours - a);
        }
        public bool isSocialIdCorrect(string si)
        {
            int[] socialIdWeights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            Func<DateTime, string> monthID = s =>
             {
                 string properMonth;
                 if (s.Year <= 1999)
                     properMonth = s.Month.ToString();
                 else if (s.Year <= 2099)
                     properMonth = (s.Month + 20).ToString();
                 else
                     properMonth = (s.Month + 40).ToString();
                 return properMonth;
             };
          
                if (si.Substring(0, 2) != birthDate.Year.ToString().Substring(2))
                {
                    return false;
                }

                if (si.Substring(2, 2) != monthID(birthDate))
                {
                    return false;
                }

                if (si.Substring(4, 2) != (birthDate.Day >= 10 ? birthDate.Day.ToString() : $"0{birthDate.Day}"))
                {
                    return false;
                }
                if (Convert.ToInt32(si.Substring(6, 2)) % 2 == 0 && this.sex == Sex.Woman)
                {
                    return false;
                }
                int controlNumber = 0;
                for (int i = 0; i < 10; i++)
                {
                    controlNumber += (socialIdWeights[i] * int.Parse(si[i].ToString()) % 10);
                }
                if (int.Parse(si[10].ToString()) != (10 - (controlNumber % 10)) % 10)
                {
                    return false;
                }
                return true;
          
            }
    }
}
