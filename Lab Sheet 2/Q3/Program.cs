using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            var query = from item in files
                        where item.length > 10000
                        orderby item.Length, item.Name
                        select new
                        {
                            Name = item.Name
                            Length = item.Length
                            CreationTime = item.CreationTime
                        }:
        }
    }
}
