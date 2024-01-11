using System;

namespace DatingProgram.DataTools
{
    internal static class DateTimeTools
    {
        public static int YearsBetween(DateTime first, DateTime second)
        {
            bool addYear = (second.Month > first.Month || second.Month == first.Month) && second.Day >= first.Day;
            return second.Year - first.Year - 1 + (addYear ? 1 : 0);
        }
    }
}
