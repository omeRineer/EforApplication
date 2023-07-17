using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTimeApp.Extensions
{
    public static class DateTimeExtensions
    {
        public static string CustomToShortDateString(this DateTime dateTime)
        {
            return dateTime.ToShortDateString().Replace('.', '/');
        }
    }
}
