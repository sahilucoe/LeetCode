namespace Problems
{
    class ReverseStringInplace
    {
        public void ReverseString(char[] s)
        {
            for(var i = 0; i < s.Length / 2; i++)
            {
                Swap(s, i, s.Length - 1 - i);
            }
        }
        private void Swap(char[] s,int firstIndex, int secondIndex)
        {
            var temp = s[firstIndex];
            s[firstIndex] = s[secondIndex];
            s[secondIndex] = temp;
        }
    }
}
