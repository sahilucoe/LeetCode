using System.Linq;

namespace LeetCode
{
    public class RemoveElement
    {
        public int Solve(int[] nums, int val)
        {
            RemoveOccurences(nums, val);
            Rearrange(nums);
            return nums.Where(x => x != int.MinValue).Count();
        }

        private void Rearrange(int[] nums)
        {
            int start = 0, end = nums.Length - 1;

            while (start < end)
            {
                if (nums[start] != int.MinValue)
                {
                    start++;
                }
                else
                {
                    while (end>=0 && nums[end] == int.MinValue)
                    {
                        end--;
                    }
                    if(end <0)
                    {
                        break;
                    }
                    if (end > start)
                    {
                        var temp = nums[start];
                        nums[start] = nums[end];
                        nums[end] = temp;
                        start++;
                    }
                }
            }
        }

        private void RemoveOccurences(int[] nums, int val)
        {
            for (int i1 = 0; i1 < nums.Length; i1++)
            {
                int num = nums[i1];
                if (num == val)
                {
                    nums[i1] = int.MinValue;
                }
            }
        }
    }
}