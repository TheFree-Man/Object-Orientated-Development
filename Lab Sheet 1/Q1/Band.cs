using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public class Band
    {
        public string BandName { get; set; }

        public int YearFormed { get; set; }

        public string Members { get; set; }

        public Band(string bandName, int yearFormed, string members)
        {
            BandName = bandName;
            YearFormed = yearFormed;
            Members = members;
        }

        public Band()
        {

        }

        public override string ToString()
        {
            return BandName;
        }
    }
}
