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

namespace Q1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Band> allBands = new List<Band>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RockBand b1 = new RockBand() { BandName = "The Foo Fighters", YearFormed = 1994, Members = "Dave Grohl, Nate Mendel, Pat Smear, Taylor Hawkins, Chris Shifflett, Rami Jafee" };
            RockBand b2 = new RockBand() { BandName = "The Rolling Stones", YearFormed = 1962, Members = "Mick Jagger, Ian Stewart, Dick Taylor, Bill Wymann, Mick Taylor" };

            PopBand b3 = new PopBand() { BandName = "The Beatles", YearFormed = 1960, Members = "John Lennon, Paul McCartney, George Harrison, Ringo Starr" };
            PopBand b4 = new PopBand() { BandName = "Green Day", YearFormed = 1986, Members = "Billie Joe Armstrong, Mike Dirnt, Tre Cool" };

            IndieBand b5 = new IndieBand() { BandName = "Artic Monkeys", YearFormed = 2002, Members = "Alex Turner, Matt Heldens, Jamie Cook, Nick O'Malley" };
            IndieBand b6 = new IndieBand() { BandName = "The Strokes", YearFormed = 1998, Members = "Julien Casablancas, Nick Valensi, Albert Hammond Jr, Nikolai Frature, Fabrizio Moretti" };

            Random rand = new Random();

            Album a1 = new Album() { Name = "Greatest Hits", YearOfRelease = rand.Next(1960, 2020), Sales = rand.Next(1000000, 10000000) };
            Album a2 = new Album() { Name = "One by One", YearOfRelease = rand.Next(1960, 2020), Sales = rand.Next(1000000, 10000000) };

            Album a3 = new Album() { Name = "Sticky Fingers", YearOfRelease = rand.Next(1960, 2020), Sales = rand.Next(1000000, 10000000) };
            Album a4 = new Album() { Name = "Blue and Lonesome", YearOfRelease = rand.Next(1960, 2020), Sales = rand.Next(1000000, 10000000) };

            Album a5 = new Album() { Name = "Sgt. Pepper's Lonely Hearts Club Band", YearOfRelease = rand.Next(1960, 2020), Sales = rand.Next(1000000, 10000000) };
            Album a6 = new Album() { Name = "White Album", YearOfRelease = rand.Next(1960, 2020), Sales = rand.Next(1000000, 10000000) };

            Album a7 = new Album() { Name = "Dookie", YearOfRelease = rand.Next(1960, 2020), Sales = rand.Next(1000000, 10000000) };
            Album a8 = new Album() { Name = "American Idiot", YearOfRelease = rand.Next(1960, 2020), Sales = rand.Next(1000000, 10000000) };

            Album a9 = new Album() { Name = "Whatever People Say I am, That's What I'm not", YearOfRelease = rand.Next(1960, 2020), Sales = rand.Next(1000000, 10000000) };
            Album a10 = new Album() { Name = "Favourite Worst Nightmare", YearOfRelease = rand.Next(1960, 2020), Sales = rand.Next(1000000, 10000000) };

            Album a11 = new Album() { Name = "Room on Fire", YearOfRelease = rand.Next(1960, 2020), Sales = rand.Next(1000000, 10000000) };
            Album a12 = new Album() { Name = "The Modern Age", YearOfRelease = rand.Next(1960, 2020), Sales = rand.Next(1000000, 10000000) };

            b1.AlbumList.Add(a1);
            b1.AlbumList.Add(a2);

            b2.AlbumList.Add(a3);
            b2.AlbumList.Add(a4);

            b3.AlbumList.Add(a5);
            b3.AlbumList.Add(a6);

            b4.AlbumList.Add(a7);
            b4.AlbumList.Add(a8);

            b5.AlbumList.Add(a9);
            b5.AlbumList.Add(a10);

            b6.AlbumList.Add(a11);
            b6.AlbumList.Add(a12);

            allBands.Add(b1);
            allBands.Add(b2);
            allBands.Add(b3);
            allBands.Add(b4);
            allBands.Add(b5);
            allBands.Add(b6);

            allBands.Sort();
            
            lstbxBands.ItemsSource = allBands;
        }

        private void lstbxBands_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Band selectedBand = lstbxBands.SelectedItem as Band;

            if (selectedBand != null)
            {
                lstbxAlbums.ItemsSource = selectedBand.AlbumList;
            }
        }
    }
}
