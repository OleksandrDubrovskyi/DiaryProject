using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace Daybook
{
    public class DataBinding
    {
        public static Diary LoadRecords(Diary book)
        {
            string dirPath = @"C:\DaybookApp\" + book.ownerName;
            string filePath = dirPath + @"\entries.txt";

            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);

            if (File.Exists(filePath))
            {
                var stringsFromFile = File.ReadAllLines(filePath);
                for (int i = 0; i < stringsFromFile.Length; i++)
                {
                    var result = stringsFromFile[i].Split('>');
                    var entry = new Entry();
                    entry.date = DateTime.ParseExact(result[0], "ddMMyyyy", CultureInfo.InvariantCulture);
                    entry.content = result[1];
                    book.daybook.Add(entry);
                }                
            }
            return book;
        }

        public static void SubmitRecords(Diary book)
        {
            string dirPath = @"C:\DaybookApp\" + book.ownerName;
            string filePath = dirPath + @"\entries.txt";

            int size = book.daybook.Count();
            var stringArray = new string[size];
            string tempString;

            for (int i = 0; i < size; i++)
            {
                tempString = book.daybook[i].date.ToString("ddMMyyyy") + ">" + book.daybook[i].content;
                stringArray[i] = tempString;
            }
            File.WriteAllLines(filePath, stringArray);
        }
    }
}
