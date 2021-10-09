using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionExtra
{
    static class Extension
    {
        public static string GetName(this Person person)
        {
            return person.ID + " " + person.Name + " " + person.Address;
        }
        public static string GetFormatType(this DateTime dateTime,char format)
        {
            return format + dateTime.ToString() + format;
        }
    }
}
