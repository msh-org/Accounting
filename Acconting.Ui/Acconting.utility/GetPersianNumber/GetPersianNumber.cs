using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acconting.utility
{
    public static class GetPersianNumber
    {
        public static string currentPersian(this string englishNumber)
        {
            string persianNumber = "";
            foreach (char ch in englishNumber)
            {
                if (char.IsNumber(ch) && !char.IsControl(ch))
                {
                    persianNumber += (char)(1776 + char.GetNumericValue(ch));
                }
                else
                {
                    persianNumber += ch;
                }
            }
            return persianNumber;
        }
    }
}
