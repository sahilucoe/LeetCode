namespace Problems
{
    internal class ClimbingStairs
    {
        public int ClimbStairs(int n)
        {
            if (n < 2)
            {
                return n;
            }
            var temp_1 = 1;
            var temp_2 = 2;

            for (int i = 3; i <= n; i++)
            {
                var temp = temp_1;
                temp_1 = temp_2;
                temp_2 = temp+temp_2;
            }
            return temp_2;
        }
    }
}
