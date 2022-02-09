using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Layout;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PersonProject;


namespace TeamGUI
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public int changesMade = 0;
        public void Refresh()
        {
        lbMembersView.ItemsSource = new ObservableCollection<TeamMember>(team.members);
        tbName.Text = team.Name;
        tbTeamManager.Text = team.manager.ToString();
        }
        Team team = new Team();
        public MainWindow()
        {
            InitializeComponent();
            team = Team.ImportXML("serialize");
            Refresh();
        }

        private void bTeamManager_Click(object sender, RoutedEventArgs e)
        {
            AddPersonWindow add = new AddPersonWindow(team.Manager);
            add.ShowDialog();
            changesMade++;
            if(team.Manager.Name != null)
            {
                Refresh();
            }
        }

        private void bDeleteMember_Click(object sender, RoutedEventArgs e)
        {
            int marked = lbMembersView.SelectedIndex;
            try
            {
                team.members.RemoveAt(marked);
                changesMade++;
            } catch(ArgumentOutOfRangeException s) {
                MessageBox.Show("Choose an employee first!");
            }
            lbMembersView.ItemsSource = new ObservableCollection<TeamMember>(team.members);
        }

        private void bAddMember_Click(object sender, RoutedEventArgs e)
        {
            TeamMember teamMember = new TeamMember();
            AddPersonWindow add = new AddPersonWindow(teamMember);
            add.ShowDialog();
            if (teamMember.Name != null)
            {
                team.addMember(teamMember);
                changesMade++;
            }
            
            lbMembersView.ItemsSource = new ObservableCollection<TeamMember>(team.members);
        }
        //Menu buttons
         void MenuClose_Click(object sender, RoutedEventArgs e)
        {
            if (changesMade != 0)
            {
                if (MessageBox.Show("Are you sure you want to quit? Changes were made!", "Quit", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    this.Close();
                }
            }
        }
        void MenuClose_Click(object sender, CancelEventArgs a)
        {
            if (changesMade != 0)
            {
                MessageBoxResult result = MessageBox.Show("Changes were made! Would you like to save?", "Quit", MessageBoxButton.YesNoCancel, MessageBoxImage.Warning);
                if(result == MessageBoxResult.Yes)
                {
                    Saving();
                }else if(result == MessageBoxResult.Cancel)
                {
                    a.Cancel = true;
                }
            }
        }
        
        private void MenuZapisz_Click(object sender, RoutedEventArgs e)
        {
            Saving();
        }
        private void Saving()
        {

            Microsoft.Win32.SaveFileDialog save = new Microsoft.Win32.SaveFileDialog();
            Nullable<bool> result = save.ShowDialog();
            if (result == true)
            {
                team.name = tbName.Text;
                string filename = save.FileName;
                Team.SaveXML(filename, team);
                changesMade = 0;
            }
        }
        private void MenuOpen_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog open = new Microsoft.Win32.OpenFileDialog();
            Nullable<bool> result = open.ShowDialog();
            if (result == true)
            {
                if (open.FileName.Contains(".xml"))
                {
                    string filename = open.FileName.Remove(open.FileName.Length - 4);
                    team = (Team)Team.ImportXML(filename);
                    Refresh();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Wrong file!");
                }
            }
        }

        private void bChangeMember_Click(object sender, RoutedEventArgs e)
        {
            TeamMember a = (TeamMember)lbMembersView.SelectedItem;
            AddPersonWindow add = new AddPersonWindow(a);
            add.ShowDialog();
            Refresh();
        }

    }
}
