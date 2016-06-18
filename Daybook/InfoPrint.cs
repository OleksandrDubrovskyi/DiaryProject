using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daybook
{
    class InfoPrint
    {
        public static string greatUser()
        {
            Console.WriteLine("Welcome to DaybookApplication!\nPlease enter your username.");
            string username = Console.ReadLine();
            return username;
        }

        public static void setContent(Entry entry)
        {
            Console.WriteLine("Please, write your entry.");
            entry.content = (Console.ReadLine());
            Console.WriteLine("Your entry for {0} is created.", entry.date.ToString("D"));
            Console.WriteLine(entry.content);
        }

        public static void updateContent(Entry entry)
        {
            Console.WriteLine("You've already had an entry for this date.");
            Console.WriteLine(entry.content);
            Console.WriteLine("Please, write new text.");
            entry.content = (Console.ReadLine());
            Console.WriteLine("Your entry for {0} is updated.", entry.date.ToString("D"));
            Console.WriteLine(entry.content);
        }

        public static bool moreEntries()
        {
            Console.WriteLine("Would you like to create another entry? Y/N");
            string choice = Console.ReadLine();
            if (choice != "y" && choice != "Y")
                return false;
            return true;
        }

        public static void showExistingEntries(Diary daybook)
        {
            Console.WriteLine("Your diary has already entries for the following dates:");
            for (int i = 0; i < daybook.daybook.Count; i++)
                Console.WriteLine(daybook.daybook[i].date.ToString("D"));

            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
        }
    }
}
