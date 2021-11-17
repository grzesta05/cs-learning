using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProject
{
    class Person
    {
        //values
        private string name;
        private string surname;
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
            sex = Sex.Inne;
        }
        void setName(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public Person(string name, string surname)
        {
            setName(name, surname);
        }
        public Person(string name, string surname, string DateofBirth, string socialid, Sex sex )
        {
            setName(name, surname);
            DateTime.TryParseExact(DateofBirth, new[] { "yyyy-MM-dd", "yyyy/MM/dd", "MM/dd/yy", "dd-MMM-yy" }, null, System.Globalization.DateTimeStyles.None, out birthDate);
            this.sex = sex;
        }

        //Functions
        public int Age()
        {
            DateTime date = new DateTime();
            date = DateTime.Now;
            return (date.Year - birthDate.Year);
        }
    }
}
