using System;

namespace LoucaLiza.utils
{
    public static class StringUtils
    {
        public static bool ContainIgnoreCase(string source, string target)
        {
            if (string.IsNullOrEmpty(source) || string.IsNullOrEmpty(target))
            {
                return false;
            }
            return source?.IndexOf(target, StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}
