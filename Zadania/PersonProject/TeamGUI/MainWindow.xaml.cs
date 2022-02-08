using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public MainWindow()
        {
            InitializeComponent();
            Team team = new Team();
            team = (Team)Team.ImportXML("serialize.xml");
            lbMembersView.ItemsSource = new ObservableCollection<TeamMember>(team.members);
            tbName.Text = team.Name;
            tbTeamManager.Text = team.manager.ToString();
        }

        private void bTeamManager_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bDeleteMember_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bAddMember_Click(object sender, RoutedEventArgs e)
        {
            TeamMember teamMember = new TeamMember();
            AddPersonWindow add = new AddPersonWindow();
            add.ShowDialog();
        }

        private void tbName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void lbMembersView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
