using System;

namespace DatingProgram.DataTools
{
    // Статический класс, содержащий методы для работы с датой и временем
    internal static class DateTimeTools
    {
        // Метод возвращает кол-во лет между двумя датами
        public static int YearsBetween(DateTime first, DateTime second)
        {
            bool addYear = (second.Month > first.Month || second.Month == first.Month) && second.Day >= first.Day;
            return second.Year - first.Year - 1 + (addYear ? 1 : 0);
        }
    }
}
