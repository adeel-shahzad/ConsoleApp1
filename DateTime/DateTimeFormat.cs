using System;
using static System.Console;

namespace DateTimePlay.Format
{
    public class DateTimeFormatTest {
        private static string dateFormat_d = "d"; // 9/24/2023 also known as short date
        private static string dateFormat_D = "D"; // Sunday, September 24, 2023 known as long date
        public DateTimeFormatTest() {
            var dateTimeNow = DateTime.Now;
            WriteLine($"DateTimeNow: {dateTimeNow.ToString(dateFormat_d)}");
            WriteLine($"DateTimeNow: {dateTimeNow.ToString(dateFormat_D)}");
        }
    }
}