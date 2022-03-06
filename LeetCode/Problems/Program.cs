using Problems;
using System;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t = new PascalTriangleII();
            Console.WriteLine(t.GetRow(3 ));
            Console.WriteLine(t.GetRow(0 ));
            Console.WriteLine(t.GetRow(1 ));
        }
    }
}
