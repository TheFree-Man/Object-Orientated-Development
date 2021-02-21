using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Mary", "Joseph", "Michael", "Sarah", "Margaret", "John" };

            var query = from name in names
                        orderby name ascending
                        select name;
                        

            foreach(var name in query)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}
