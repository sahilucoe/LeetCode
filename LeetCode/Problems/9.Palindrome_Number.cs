namespace Problems
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            var input = x;
            var reverseOfX = 0;

            // 1. Compute reverse of X
            while (input > 0)
            {
                reverseOfX *= 10;
                var rem = input % 10;
                input /= 10;
                reverseOfX += rem;
            }

            // 2. Check if it is equal to X
            return reverseOfX == x;
        }
    }
}
