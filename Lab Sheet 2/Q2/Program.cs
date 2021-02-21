using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = new DirectoryInfo("C:\\Windows").GetFiles();

            var query = from item in items
                        where item.length > 10000
                        orderby item.Length, item.Name
                        select new MyFileInfo
                        {
                            Name = item.Name
                            Length = item.Length,
                            CreationTime = item.CreationTime
                        };
        }
    }
}
