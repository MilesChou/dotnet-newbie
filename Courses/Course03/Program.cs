namespace Course03
{
    public static class Course03
    {
        private static void Main(string[] args)
        {
            var a = float.Parse(args[0]);
            var b = float.Parse(args[1]);
            var c = float.Parse(args[2]);

            Console.WriteLine($"{a} , {b} , {c}");

            Console.WriteLine($"中間數是 {Find(a, b, c)}");

            Console.WriteLine($"中間數是 {NewFind(a, b, c)}");
        }

        public static float Find(float a, float b, float c)
        {
            if ((c > a && a > b) || (b > a && a > c))
            {
                return a;
            }

            if ((a > b && b > c) || (c > b && b > a))
            {
                return b;
            }

            if ((b > c && c > a) || (a > c && c > b))
            {
                return c;
            }

            return 0;
        }

        /// <summary>
        /// 做排序後，取中間位
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>三數中的中間數</returns>
        public static float NewFind(float a, float b, float c)
        {
            IEnumerable<float> floats = new List<float>()
            {
                a, b, c
            };

            return floats.OrderBy(x => x).ToList()[1];
        }
    }
}