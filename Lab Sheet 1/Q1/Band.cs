using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public abstract class Band : IComparable
    {
        public string BandName { get; set; }

        public int YearFormed { get; set; }

        public string Members { get; set; }

        public List<Album> AlbumList { get; set; }

        public Band(string bandName, int yearFormed, string members)
        {
            BandName = bandName;
            YearFormed = yearFormed;
            Members = members;

            AlbumList = new List<Album>();
        }

        public Band() : this("Unknown", 1960, "Unknown") { }

        public override string ToString()
        {
            return BandName;
        }

        public int CompareTo(object obj)
        {
            Band otherBand = obj as Band;
            return this.BandName.CompareTo(otherBand.BandName);
        }
    }

    public class RockBand : Band
    {
        public override string ToString()
        {
            return base.ToString() + " - Rock Band";
        }
    }

    public class PopBand : Band
    {
        public override string ToString()
        {
            return base.ToString() + " - Pop Band";
        }
    }

    public class IndieBand : Band
    {
        public override string ToString()
        {
            return base.ToString() + " - Indie Band";
        }
    }
}
