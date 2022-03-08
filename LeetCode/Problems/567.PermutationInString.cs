using System.Collections.Generic;
using System.Linq;
namespace Problems
{
    internal class PermutationInString
    {
        public bool CheckInclusion(string s1, string s2)
        {
            var dp = new int[256];
            var temp = new int[256];
            foreach (char c in s1)
            {
                dp[c]++;
            }

            var count = 0;
            var result = false;
            int start = 0, end = 0;
            while (start < s2.Length && end < s2.Length)
            {
                temp[s2[end]]++;

                
                if(count == s1.Length)
                {
                    result = true;
                    break;
                }
                if (temp[s2[end]] <= dp[s2[end]])
                {
                    count++;
                    end++;
                }
                else
                {
                    while (start < s2.Length && temp[s2[end]] > dp[s2[end]])
                    {
                        temp[s2[start]]--;

                        start++;
                    }
                    count = end - start+1;
                    end++;
                }
            }
            if (count == s1.Length)
            {
                result = true;
            }
            return result;
        }
    }
}
