namespace Problems
{
    internal class IsSubsequenceSolution
    {
        public bool IsSubsequence(string s, string t)
        {
            int iterator_s = 0;
            var iterator_t = 0;
            while (iterator_s < s.Length && iterator_t < t.Length)
            {
                if(s[iterator_s] == t[iterator_t])
                {
                    iterator_s++;
                    iterator_t++;
                }
                else
                {
                    iterator_t++;
                }
            }
            return iterator_s == s.Length;
        }
    }
}
