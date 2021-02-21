using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 5, 3, 6, 10, 12, 8 };

            var query1 = numbers
                         .OrderByDescending(n => n);

            var query2 = query1
                         .Where(n => n < 8);

            var query3 = query2
                .Select(n => DoubleIt(n));

            foreach(var item in query3)
            {
                Console.WriteLine(item);
            }
        }
    }
}
