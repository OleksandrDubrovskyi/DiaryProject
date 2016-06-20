using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daybook
{
    public class Entry
    {
        public DateTime date { get; set; }

        public string content = "";

        public Entry(DateTime date)
        {
            this.date = date;
            this.content = "";           
        }

        public Entry()
        {

        }

        public void showContent(Entry entry)
        {
            Console.WriteLine(entry.content);
        }
    }
}
