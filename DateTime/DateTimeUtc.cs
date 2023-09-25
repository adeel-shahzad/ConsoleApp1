using System;
using static System.Console;

namespace DateTimeTest.Utc
{
    public class DateTimeUtcTest {
        public DateTimeUtcTest() {
            var dateTimeNowLocal = DateTime.Now;
            var dateTimeNowUtc = DateTime.UtcNow;
            var convertedToUtc = TimeZoneInfo.ConvertTimeToUtc(dateTimeNowLocal);
            WriteLine("Local time: " + dateTimeNowLocal);
            WriteLine("UTC: " + dateTimeNowUtc);
            WriteLine("Local to UTC: " + convertedToUtc);
        }
    }
}