using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acconting.utility
{
    public  class DateAndTime
    {
        public string PersianDate()
        {
            var date = DateTime.Now;
            PersianCalendar persianCalendar = new PersianCalendar();

            string year = persianCalendar.GetYear(date).ToString();
            string month = persianCalendar.GetMonth(date).ToString().PadLeft(2, '0');
            string day = persianCalendar.GetDayOfMonth(date).ToString().PadLeft(2, '0');
            string persianDate = string.Format("{0}/{1}/{2}", year, month, day);
            return persianDate;
        }
        public string time()
        {
            return DateTime.Now.ToString("HH:mm:ss");

        
        }
    }
}
