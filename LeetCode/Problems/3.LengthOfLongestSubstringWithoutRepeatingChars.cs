using System;
using System.Collections.Generic;

namespace Problems
{
    internal class LengthOfLongestSubstringWithoutRepeatingChars
    {
        public int LengthOfLongestSubstring(string s)
        {
            int start = 0, end = start;
            var temp = new int[256];
            var maxSoFar = 0;

            while (start < s.Length && end < s.Length)
            {
                if (temp[s[end]] == 0)
                {
                    temp[s[end]] = temp[s[end]] + 1;
                    maxSoFar = Math.Max(maxSoFar, end - start + 1);
                    end++;
                }
                else {
                    while (start < s.Length && temp[s[end]] != 0)
                    {
                        temp[s[start]] = temp[s[start]] - 1;
                        start++;
                    }

                }
            }
            return maxSoFar;
        }
    }
}
