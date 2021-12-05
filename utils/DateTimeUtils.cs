using System;

namespace LoucaLiza.utils
{
    class DateTimeUtils
    {
        public static DateTime? TryParse(string text)
        {
            try
            {
                return DateTime.Parse(text);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
