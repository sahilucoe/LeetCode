using System;
using System.Text;

namespace Problems
{
    internal class ReverseWordsInAString
    {
        public string ReverseWords(string s)
        {
            int start = 0, end = 0;
            while (end < s.Length)
            {
                if (s[end] == ' ')
                {
                    s = Reverse(s, start, end-1);
                    start = ++end;
                }
                else if(end == s.Length - 1)
                {
                    s = Reverse(s, start, end);
                    start = ++end;
                }
                else
                {
                    end++;
                }
            }
            return s;
        }

        private string Reverse(string str, int start, int end)
        {
            var s = new StringBuilder(str);
            while (start < end)
            {
                var temp = s[start];
                s[start] = s[end];
                s[end] = temp;
                start++;
                end--;
            }
            return s.ToString();
        }
    }
}
