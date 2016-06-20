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
            Console.WriteLine("Welcome to DaybookApplication!\nPlease enter your username:");
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
            Console.WriteLine("\nYou've already had an entry for this date:\n");
            Console.WriteLine(entry.content);
            whatToDo(entry);
        }

        public static void whatToDo(Entry entry)
        {
            Console.WriteLine("\nWhat you would like to do?\n" +
                "\nPress A to add text, R to rewrite, or Q to quit.\n");
            string usersChoice = Console.ReadLine().ToLower();

            switch (usersChoice)
            {
                case "a":
                    addText(entry);
                    break;
                case "r":
                    rewriteEntry(entry);
                    break;
                case "q":
                    break;
                default:
                    whatToDo(entry);
                    break;
            }
        }

        public static void addText(Entry entry)
        {
            Console.WriteLine("\nPlease, write text to add.\n");
            entry.content += (" " + Console.ReadLine());
            Console.WriteLine("\nYour entry for {0} is updated.\n", entry.date.ToString("D"));
            Console.WriteLine(entry.content);
        }

        public static void rewriteEntry(Entry entry)
        {
            Console.WriteLine("\nPlease, write new text.\n");
            entry.content = Console.ReadLine();
            Console.WriteLine("Your entry for {0} is updated.\n", entry.date.ToString("D"));
            Console.WriteLine(entry.content);
        }

        public static bool moreEntries()
        {
            Console.WriteLine("\nWould you like to create another entry? Y/N\n");
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
