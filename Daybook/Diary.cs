using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daybook
{
    public class Diary
    {
        public List<Entry> daybook = new List<Entry>();
        public string ownerName;

        public Diary(string name)
        {
            ownerName = name;
        }

        public void setEntry()
        {
            while (InfoPrint.moreEntries())
            {
                DateTime date = UserQuery.getDate();                                 
                var entry = checkDate(daybook, date);

                if (entry.content == "")
                {
                    InfoPrint.setContent(entry);
                    daybook.Add(entry);
                    daybook = sortDaybook(daybook);
                }      
                else
                    InfoPrint.updateContent(entry);          
            }
        }

        public Entry checkDate(List<Entry> list, DateTime date)
        {
            for (int i = 0; i < list.Count; i++)
                if (list[i].date.Date.Equals(date.Date))
                    return list[i];
            var entry = new Entry(date);
            return entry;
        }

        public List<Entry> sortDaybook(List<Entry> list)
        {
            List<Entry> SortedList = list.OrderBy(o => o.date).ToList();
            return SortedList;
        }        
    }
}
