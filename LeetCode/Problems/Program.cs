using Problems;
using System;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t = new LongestPalindromincSubstring();
            Console.WriteLine(t.LongestPalindrome("babad"));
            Console.WriteLine(t.LongestPalindrome("cbbd"));
        }
    }
}
