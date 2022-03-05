namespace Problems
{
    internal class LongestPalindromincSubstring
    {
        public string LongestPalindrome(string s)
        {
            var dp = new int[s.Length,s.Length];
            int result_start=0, result_end=0;
            var maxSoFar = 0;
            for(int i = 0; i < s.Length; i++)
            {
                dp[i,i] = 1;
            }

            for(int i = 0; i < s.Length; i++)
            {
                for(int j=i;j<s.Length; j++)
                {
                    if (IsPalindrome(s, i, j, dp))
                    {
                        if (maxSoFar < j - i + 1)
                        {
                            maxSoFar = j-i+1;
                            result_start = i;
                            result_end = j;
                        }
                    }
                }
            }
            return s.Substring(result_start, result_end - result_start + 1);

        }
        private bool IsPalindrome(string s,int start,int end, int[,] dp)
        {
            if (dp[start, end] != 0)
            {
                return dp[start, end] == 1;
            }

            if (start > end)
            {
                dp[start, end] = 1;
                return true;
            }
            if (s[start] != s[end])
            {
                dp[start, end] = -1;
                return false;
            }
            else
            {
                var sub = IsPalindrome(s,start+1,end-1,dp);
                dp[start, end] = sub?1:-1;
                return sub;
            }
        }
    }
}
