using System;

namespace Problems
{
    internal class MoveZeroesSolution
    {
        public void MoveZeroes(int[] nums)
        {
            int j = 1;
            for(int i = 0; i <nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    j = Math.Max(j, i + 1); // optimization, simply j = i+1 also works
                    while (j<nums.Length && nums[j] == 0)
                    {
                        j++;
                    }
                    if (j == nums.Length)
                    {
                        break;
                    }

                    var temp = nums[j];
                    nums[j] = nums[i];
                    nums[i] = temp;
                }
            }
        }
    }
}
