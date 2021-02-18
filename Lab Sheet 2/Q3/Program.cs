using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
