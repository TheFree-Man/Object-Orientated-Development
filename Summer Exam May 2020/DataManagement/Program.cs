using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Q1;

namespace DataManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            PhoneData db = new PhoneData();

            using (db)
            {
                Phone p1 = new Phone("Samsung S20", 500, "Android", "/images/android.png", "");
                Phone p2 = new Phone("iPhone 11", 600, "IOS", "/images/apple.png", "");

                Console.WriteLine("Creating phones");

                db.Phones.Add(p1);
                db.Phones.Add(p2);

                Console.WriteLine("Adding to database");

                db.SaveChanges();

                Console.WriteLine("Saved to database");
                Console.WriteLine("Press enter to continue");
                Console.Read();

            }
        }
    }
}
