using System;

namespace Problems
{
    internal class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int start = 0, end = height.Length - 1, max = 0;
            while (start < end)
            {
                max = Math.Max(max, Math.Min(height[start], height[end]) * (end - start));
                if (height[start] < height[end])
                {
                    start++;
                }
                else 
                { 
                    end--; 
                }
            }
            return max;
        }
    }
}
