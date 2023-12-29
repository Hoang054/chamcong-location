using System;

namespace WeekCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập ngày (dd/mm/yyyy): ");
            string inputDateStr = Console.ReadLine();

            if (DateTime.TryParseExact(inputDateStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime selectedDate))
            {
                DateTime startDay = GetStartOfWeek(selectedDate);
                DateTime endDay = startDay.AddDays(6);
                int weekNumber = GetWeekNumber(selectedDate);

                Console.WriteLine($"Tuần thứ {weekNumber} từ {startDay:dd/MM/yyyy} đến {endDay:dd/MM/yyyy}");
            }
            else
            {
                Console.WriteLine("Ngày không hợp lệ. Vui lòng nhập lại.");
            }
        }

        static DateTime GetStartOfWeek(DateTime date)
        {
            int daysUntilMonday = ((int)date.DayOfWeek - (int)DayOfWeek.Monday + 7) % 7;
            return date.Date.AddDays(-daysUntilMonday);
        }

        static int GetWeekNumber(DateTime date)
        {
            System.Globalization.CultureInfo ciCurr = System.Globalization.CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(date, System.Globalization.CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
        }
    }
}
