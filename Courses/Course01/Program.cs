namespace Courses01
{
    public static class Course1
    {
        private static void Main(string[] args)
        {
            int score;
            try
            {
                score = int.Parse(args[0]);
            }
            catch (FormatException)
            {
                Console.WriteLine("輸入非數字，請重新輸入");
                return;
            }

            Console.WriteLine(Grade(score));
        }

        public static string Grade(int score)
        {
            if (score is > 100 or < 0)
            {
                return "分數錯誤，請重新輸入";
            }

            return score switch
            {
                >= 90 => "考試優秀",
                >= 80 => "考試良好",
                >= 60 => "考試及格",
                >= 0 => "下次繼續努力",
                _ => throw new ArgumentOutOfRangeException(nameof(score), score, null)
            };
        }
    }
}