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
        NORTHWNDEntities db = new NORTHWNDEntities();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ex1Button_Click(object sender, RoutedEventArgs e)
        {
            var query = from c in db.Customers
                        group c by c.Country into g
                        orderby g.Count() descending
                        select new
                        {
                            Category = g.Key,
                            Count = g.Count()
                        };

            Ex1DGDisplay.ItemsSource = query.ToList();
        }

        private void Ex2Button_Click(object sender, RoutedEventArgs e)
        {
            var query = from c in db.Customers
                        where c.Country == "Italy"
                        select new
                        {
                            Name = c.ContactName,
                            Order = c.Orders,
                            ID = c.CustomerID,
                            CName = c.CompanyName,
                            CDemographics = c.CustomerDemographics
                        };

            Ex2DGDisplay.ItemsSource = query.ToList();
                        
        }

        private void Ex3Button_Click(object sender, RoutedEventArgs e)
        {
            var query = from p in db.Products
                        where p.UnitsInStock - p.UnitsOnOrder > 0
                        select new
                        {
                            Product = p.ProductName,
                            Available = p.UnitsInStock
                        };

            Ex3DGDisplay.ItemsSource = query.ToList();
        }

        private void Ex4Button_Click(object sender, RoutedEventArgs e)
        {
            var query = from o in db.Order_Details
                        where o.Discount > 1
                        select new
                        {
                            ProductName = o.Product.ProductName,
                            DiscountGiven = o.Discount
                        };

            Ex4DGDisplay.ItemsSource = query.ToList();
        }

        private void Ex5Button_Click(object sender, RoutedEventArgs e)
        {
            var query = (from o in db.Orders
                        select o.Freight).Sum();

            Ex3TblkDetails.Text = string.Format("Value of Orders {1:C}}", query);

        }

        private void Ex6Button_Click(object sender, RoutedEventArgs e)
        {
            var query = from p in db.Products
                        orderby p.UnitPrice descending
                        select new
                        {
                            CategoryID = p.CategoryID,
                            CategoryName = p.Category.CategoryName,
                            ProductName = p.ProductName,
                            UnitPrice = p.UnitPrice
                        };

            Ex6DGDisplay.ItemsSource = query.ToList();
        }

        private void Ex7Button_Click(object sender, RoutedEventArgs e)
        {
            var query = from c in db.Order_Details
                        group c by c.Order.OrderID into g
                        orderby g.Count() descending
                        select new
                        {
                            CustomerID = g.Key,
                            NumberOfOrders = g.Count()

                        };

            Ex7DGDisplay.ItemsSource = query.ToList();
        }

        private void Ex8Button_Click(object sender, RoutedEventArgs e)
        {
            var query = from c in db.Order_Details
                        group c by c.Order.OrderID into g
                        orderby g.Count() descending
                        select new
                        {
                            CustomerID = g.Key,
                            NumberOfOrders = g.Count()

                        };

            Ex8DGDisplay.ItemsSource = query.ToList();
        }

        private void Ex9Button_Click(object sender, RoutedEventArgs e)
        {
            var query = from c in db.Customers
                        //where c.Order_Details.Quantity == 0
                        select new
                        {
                            CompanyName = c.CompanyName,
                            //NumberOfOrders = c.Order_Details.Quantity
                        };
        }
    }
}
