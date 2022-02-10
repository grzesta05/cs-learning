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

        private TeamManager man;
        private Person prs;
        private TeamMember mem;
        public AddPersonWindow(TeamManager person):this()
        {
            
            prs = person;
            
            
                tbSocialID.Text = person.SocialId;
                tbName.Text = person.Name;
                tbSurname.Text = person.Surname;
                tbBirthDate.Text = (person.birthDate != DateTime.MinValue? person.birthDate.ToShortDateString(): "");
                cbGender.SelectedIndex = ((int)person.sex);
                lbExperience.Visibility = Visibility.Visible;
                tbExperience.Visibility = Visibility.Visible;
                tbExperience.Text = person.experience.ToString();
            
        }

        public AddPersonWindow(TeamMember person) : this()
        {

            prs = person;

            tbSocialID.Text = person.SocialId;
            tbName.Text = person.Name;
            tbSurname.Text = person.Surname;
            tbBirthDate.Text = (person.birthDate != DateTime.MinValue ? person.birthDate.ToShortDateString() : "");
            cbGender.SelectedIndex = ((int)person.sex);
            lbFunction.Visibility = Visibility.Visible;
            tbFunction.Visibility = Visibility.Visible;
            tbFunction.Text = person.function;

        }
        public AddPersonWindow()
        {
            InitializeComponent();
        }

        private void bCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
       
        private void bAccept_Click(object sender, RoutedEventArgs e)
        {
            
            if (tbSocialID.Text != "" && tbName.Text != "" && tbSurname.Text != "" && cbGender.SelectedIndex != -1)
            {
                string[] fdate = { "yyyy-MM-dd", "yyyy/MM/dd", "MM/dd/yy", "dd-MMM-yy", "dd-MMM-yyyy", "dd.MM.yyyy" };

                prs.SocialId = tbSocialID.Text;
                prs.Name = tbName.Text;
                prs.Surname = tbSurname.Text;


                if (!DateTime.TryParseExact(tbBirthDate.Text, fdate, null, DateTimeStyles.None, out DateTime date))
                {
                    string message = "Wrong date format! Please try the following: \n";
                    for (int i = 0; i < fdate.Length; i++)
                    {
                        message += (fdate[i] + (i==fdate.Length-1? "" : ", "));
                    }
                    MessageBox.Show(message);
                }
                else
                {
                    Console.WriteLine(date.ToString());
                    prs.birthDate = date;
                    prs.sex = (Sex)cbGender.SelectedIndex;
                    
                    if(prs is TeamManager && tbExperience.Text !="") 
                    {
                        man = (TeamManager)prs;
                        if(int.TryParse(tbExperience.Text, out man.experience))
                        {
                            DialogResult = true;
                        }
                        else
                        {
                            MessageBox.Show("Not a number!");
                        }
                    }else if(prs is TeamMember && tbFunction.Text != "")
                    {
                        mem = (TeamMember)prs;
                        mem.function = tbFunction.Text;
                        DialogResult = true;
                    }
                    else
                    {
                        MessageBox.Show("Function cannot be empty!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Input cannot be empty!");
            }
            
        }
    }
}
