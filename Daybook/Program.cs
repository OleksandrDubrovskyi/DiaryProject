using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Daybook
{
    class Program
    {
        //Specter course capstone project #1
        //      DayBook Application

        static void Main(string[] args)
        {
            var daybook = new Diary(InfoPrint.greatUser());

            DataBinding.LoadRecords(daybook);

            if (daybook.daybook.Count > 0)
                InfoPrint.showExistingEntries(daybook);

            daybook.setEntry();

            DataBinding.SubmitRecords(daybook);
        }
    }
}
