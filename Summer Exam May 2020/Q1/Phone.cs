using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public class Phone
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }

        public Phone()
        {

        }

        public Phone(string name, double price, string operatingSystem, string os_Image = "", string phone_Image = "")
        {
            Name = name;
            Price = price;
            OperatingSystem = operatingSystem;
            OS_Image = os_Image;
            Phone_Image = phone_Image;
        }

        public void IncreasePrice(double percentage)
        {
            Price += Price * percentage;
        } 

    }
}
