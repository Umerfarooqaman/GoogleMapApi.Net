using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace GoogleMapServices
{
   public static class DateTimeExtention
    {

        public static string FormatAsWeb(this DateTime? dt)
        {
            try
            {

                return string.Format("{0:yyyy-MM-ddTHH:mm:ss.FFFZ}", dt.Value.ToUniversalTime());
            }
            catch (Exception)
            {

                return string.Empty;
            }
        }

        public static DateTime? ParseFromWeb(this string datetime)
        {
            try
            {

                return DateTime.ParseExact(datetime, "yyyy-MM-ddTHH:mm:ss.FFF'Z'", CultureInfo.InvariantCulture);

            }
            catch (Exception)
            {

                return null;
            }
        }

    }
}
