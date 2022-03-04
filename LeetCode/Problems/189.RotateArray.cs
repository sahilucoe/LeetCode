using System;

namespace Problems
{
    internal class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            // remove redundant rotations
            k = k % nums.Length;

            var temp = new int[nums.Length];

            for (var i = k; i < nums.Length; i++)
            {
                temp[i] = nums[i - k];
            }
            for (int j = 0; j < k; j++)
            {
                temp[j] = nums[nums.Length - k + j];
            }
            Array.Copy(temp, nums, nums.Length);
        }
    }
}
