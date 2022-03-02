using System.Linq;

namespace LeetCode
{
    internal class RemoveDuplicates
    {
        public RemoveDuplicates()
        {
        }

        public int Solve(int[] nums)
        {
            ConvertDuplicatesToIntMinValue(nums);
            Rearrange(nums);
            return nums.Where(x => x != int.MinValue).Count();
        }

        private void Rearrange(int[] nums)
        {
            int i = 0, j = i + 1;

            while (i < nums.Length)
            {
                if (nums[i] != int.MinValue)
                {
                    i++;
                }
                else
                {
                    j = i;
                    while (j < nums.Length && nums[j] == int.MinValue)
                    {
                        j++;
                    }
                    if (j == nums.Length)
                    {
                        break;
                    }

                    var temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                    i++;
                }
            }
        }

        private void ConvertDuplicatesToIntMinValue(int[] nums)
        {
            var start = nums[0];
            var index = 1;
            while (index < nums.Length)
            {
                if (nums[index] == start)
                {
                    nums[index] = int.MinValue;
                }
                else
                {
                    start = nums[index];
                }
                index++;
            }
        }
    }
}