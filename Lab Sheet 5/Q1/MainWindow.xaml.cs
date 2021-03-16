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

namespace Q1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Model1Container db;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db = new Model1Container();

            var query = from a in db.Bands
                        select a;

            lstbxBands.ItemsSource = query.ToList();
        }

        private void lstbxBands_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Band selectedBand = lstbxBands.SelectedItem as Band;

            if (selectedBand != null)
            {
                var query = from b in db.Albums
                            where b.BandId == selectedBand.Id
                            select b.Name;

                lstbxAlbums.ItemsSource = query.ToList();
            }
        }
    }
}