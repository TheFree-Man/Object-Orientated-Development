using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public class Album
    {
        public String Name { get; set; }

        public int YearOfRelease { get; set; }

        public int Sales { get; set; }

        public Album(string name, int yearOfRelease, int sales)
        {
            Name = name;
            YearOfRelease = yearOfRelease;
            Sales = sales;
        }

        public Album()
        {

        }


        public override string ToString()
        {
            return string.Format($"{Name} - Released in: {YearOfRelease}, Sales: {Sales}");
        }
    }
}
