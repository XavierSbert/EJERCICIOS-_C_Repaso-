using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewExercises_datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me a date: ");
            string intro = Console.ReadLine();
            DateTime dateTime = DateTime.ParseExact(intro, "dd/MM/yyyy", null);
            var now = DateTime.Now;
            var day = (now - dateTime).ToString(@"dd");

            if (dateTime < now)
            {
                Console.WriteLine("It has been " + day + " days since " + dateTime.ToString("dd-MM-yyyy"));
            }
            else
            {
                Console.WriteLine(day + " days left for " + dateTime.ToString("dd-MM-yyyy"));
            }

            Console.Write("Give me a time: ");
            string intro2 = Console.ReadLine();

            DateTime dateTime2 = DateTime.ParseExact(intro2, "h:mm tt", CultureInfo.InvariantCulture);

            TimeSpan res = DateTime.Now.Subtract(dateTime2);

            Console.WriteLine($"{ intro2 } was {res.Hours} hours and {res.Minutes} minutes");

            Console.ReadLine();

        }
    }
}
