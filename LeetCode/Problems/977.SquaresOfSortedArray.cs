using Problems.HelperUtils;
using System.Linq;

namespace Problems
{
    internal class SquaresOfSortedArray
    {
        public int[] SortedSquares(int[] nums)
        {
            nums = nums.Select(x => x * x).ToArray();
            MergeSort.Sort(nums,0,nums.Length-1);
            return nums;

        }
    }
}
