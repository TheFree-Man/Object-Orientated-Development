using System;
using System.Collections.Generic;
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

namespace GameApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Game> AllGames;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Game.GameData db = new Game.GameData();

            string[] platforms = { "All", "PC, Xbox, PS, Switch", "PS", "Xbox", "Switch" };
            cbxPlatform.ItemsSource = platforms;

            var query = from g in db.Games
                        select g;

            AllGames = query.ToList();

            lstbxGames.ItemsSource = AllGames;
        }

        private void cbxPlatform_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Game.GameData db = new Game.GameData();

            lstbxGames.ItemsSource = null;

            var query = from g in db.Games
                        where cbxPlatform.SelectedItem.ToString() == g.Platform
                        select g;

            AllGames = query.ToList();
            lstbxGames.ItemsSource = AllGames;

        }
    }
}
