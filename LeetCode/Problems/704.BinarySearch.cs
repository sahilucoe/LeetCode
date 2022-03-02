namespace LeetCode
{
	public class BinarySearchSolution
	{
		public int Search(int[] nums, int target)
		{
			return Search(nums, target, 0, nums.Length - 1);
		}
		public int Search(int[] nums, int target, int startIndex, int endIndex)
		{
			if (startIndex > endIndex)
				return -1;

			var mid = startIndex + (endIndex - startIndex) / 2;
			if (nums[mid] == target)
			{
				return mid;
			}
			else if (nums[mid] < target)
			{
				return Search(nums, target, mid + 1, endIndex);
			}
			else
			{
				return Search(nums, target, startIndex, mid - 1);
			}
		}
	}
}