﻿namespace Hellstrap.Extensions
{
    static class DateTimeEx
    {
        public static string ToFriendlyString(this DateTime dateTime)
        {
            return dateTime.ToString("dddd, d MMMM yyyy 'at' h:mm:ss tt", CultureInfo.InvariantCulture);
        }
    }
}