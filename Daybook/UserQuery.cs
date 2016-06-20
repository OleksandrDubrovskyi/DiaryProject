using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daybook
{
    class UserQuery
    {
        public static DateTime getDate()
        {
            Console.Clear();
            Console.WriteLine("Enter the date of your entry in one of following formats:");
            Console.WriteLine("\n                  D/M/YYYY or D.M.YYYY" );
            DateTime date;
            while (true)
            {
                string input = Console.ReadLine();
                if (!DateTime.TryParse(input, out date))
                {
                    Console.WriteLine("  Unable to parse '{0}'.", input);
                    Console.WriteLine("Please, enter a valid date.");
                }
                else break;
            }
            return date;
        }
    }
}
