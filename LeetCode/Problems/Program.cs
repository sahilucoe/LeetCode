using Problems;
using System;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t = new SquaresOfSortedArray();
            Console.WriteLine(t.SortedSquares(new[] {-4, -1, 0, 3, 10}));
        }
    }
}
