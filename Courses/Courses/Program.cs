namespace Courses
{
    public class Course_1
    {
        static void Main(string[] args)
        {
            int.TryParse(args[0], out var score);

            Console.WriteLine(Grade(score));
        }

        public static string Grade(int score) => score switch
        {
            > 100 => "分數錯誤，請重新輸入",
            >= 90 => "考試優秀",
            >= 80 => "考試良好",
            >= 60 => "考試及格",
            >= 0 => "下次繼續努力",
            _ => "分數錯誤，請重新輸入",
        };
    }
}