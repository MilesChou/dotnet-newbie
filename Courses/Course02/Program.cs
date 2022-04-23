namespace Course02
{
    public static class Course02
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(HowAbout(DateTime.Now, 30, false));
        }

        public static string HowAbout(DateTime today, float temperature, bool isGoodWeather)
        {
            if (IsTodayHoliday(today))
            {
                return temperature >= 30
                    ? "今天外出，去游泳"
                    : "今天外出，去爬山";
            }

            return isGoodWeather
                ? "今天工作，去客戶單位談業務"
                : "今天工作，在公司上網查資料";
        }

        private static bool IsTodayHoliday(DateTime today)
        {
            return today.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday;
        }
    }
}