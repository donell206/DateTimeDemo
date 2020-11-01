using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int someInteger;
            //someInteger = 10;

            //char someChar;
            //someChar = 'A';

            //DateTime datum;  //declare
            //datum = new DateTime(); //init

            DateTime geboorteJaarMohammed = new DateTime(2002, 2, 27);
            Console.WriteLine(geboorteJaarMohammed);

            DateTime geboorteJaarToon = new DateTime(2005, 7, 27,4,25,50);
            Console.WriteLine(geboorteJaarToon);

            if (geboorteJaarMohammed > geboorteJaarToon)
            {
                Console.WriteLine("Mohammed is jonger");
            }
            else
            {
                Console.WriteLine("Toon is Jonger");
            }



            DateTime date = new DateTime();
            DateTime now = DateTime.Now;

            Console.WriteLine(now.AddDays(-2));
            Console.WriteLine(now.AddMinutes(2));
            Console.WriteLine(now.AddSeconds(50));
            Console.WriteLine(now.Kind);
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.Day);
            Console.WriteLine(now.DayOfWeek);
            Console.WriteLine(now.DayOfYear);
            Console.WriteLine($"{now:HH:mm:ss}");
            Console.WriteLine($"{utc:HH:mm:ss}");

            // https://www.youtube.com/watch?v=iYsdAyKBN6w

        }
    }
}
