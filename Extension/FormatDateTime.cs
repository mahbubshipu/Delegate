using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    public static class FormatDateTime
    {
        public static string GetFormatTime(this DateTime dateTime,char format)
        {
            return format + dateTime.ToString() + format;
        }
    }
}
