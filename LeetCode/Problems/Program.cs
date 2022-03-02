using System;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t = new BinarySearchSolution();
            Console.WriteLine(t.Search(new[] { -1, 0, 3, 5, 9, 12 },9));
            Console.WriteLine(t.Search(new[] { -1, 0, 3, 5, 9, 12 },2));
        }
    }
}
