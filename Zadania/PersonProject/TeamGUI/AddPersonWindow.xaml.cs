using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using PersonProject;

namespace TeamGUI
{
    /// <summary>
    /// Logika interakcji dla klasy AddPersonWindow.xaml
    /// </summary>
    public partial class AddPersonWindow : Window
    {
        private Person prs;
        public AddPersonWindow(Person person):this()
        {
            prs = person;
            if(person is TeamManager)
            {
                tbSocialID.Text = person.SocialId;
                tbName.Text = person.Name;
                tbSurname.Text = person.Surname;
                tbBirthDate.Text = person.birthDate.ToString("dd-MMM-yyyy");
                cbGender.SelectedIndex = ((int)person.sex);
            }
        }
        public AddPersonWindow()
        {
            InitializeComponent();
        }

        public void AcceptOnClick()
        {
            if(tbSocialID.Text != "" && tbName.Text != "" && tbSurname.Text != "")
            {
                prs.SocialId = tbSocialID.Text;
                prs.Name = tbName.Text;
                prs.Surname = tbSurname.Text;
                string[] fdate = {"yyyy-MM-dd", "yyyy/MM/dd", "MM/dd/yy", "dd-MMM-yy"};
                DateTime.TryParseExact(tbBirthDate.Text, fdate, null, DateTimeStyles.None, out DateTime date);
            }
        }


        
    }
}
