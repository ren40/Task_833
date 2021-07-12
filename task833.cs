namespace DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> rus_week = new Dictionary<string, string>();

            rus_week.Add("Понедельник", "Monday");
            rus_week.Add("Вторник", "Tuesday");
            rus_week.Add("Среда", "Wednesday");
            rus_week.Add("Четверг", "Thursday");
            rus_week.Add("Пятница", "Friday");
            rus_week.Add("Суббота", "Saturday");
            rus_week.Add("Воскресенье", "Sunday");

            Console.WriteLine("Введите день недели и число");
            string date = Console.ReadLine();

            int day = int.Parse(date.Split(" ")[1]);

            DateTime datenow = DateTime.Now;

            datenow = datenow.AddDays((double)1);

            while (true)
            {
                if (datenow.Day == day && rus_week[date.Split(" ")[0]] == datenow.DayOfWeek.ToString())
                {
                    break;
                }
                datenow = datenow.AddDays((double)1);
            }

            Console.WriteLine($"Ответ:{datenow.ToShortDateString()}");
        }
    }
}
