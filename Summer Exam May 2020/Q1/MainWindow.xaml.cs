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
        List<Phone> AllPhones;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Phone p1 = new Phone("Huawei p20 Pro", 550, "Android", "", "");
            //Phone p2 = new Phone("iPhone 12 Pro Max", 1200, "iOS", "", "");

            PhoneData db = new PhoneData();

            var query = from p in db.Phones
                        select p;

            AllPhones = query.ToList();

            lstbxPhone.ItemsSource = AllPhones;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Phone selectedPhone = lstbxPhone.SelectedItem as Phone;

            if (selectedPhone != null)
            {
                imgPhone.Source = new BitmapImage(new Uri(selectedPhone.Phone_Image, UriKind.Relative));
                tblkPrice.Text = $"{selectedPhone.Price:C}";
            }
        }
    }
}
