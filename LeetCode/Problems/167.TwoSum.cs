namespace Problems
{
    internal class TwoSum_SortedArray
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int start=0,end=numbers.Length-1;

            while (start < end)
            {
                var sum = numbers[start]+numbers[end];
                if(sum == target)
                {
                    return new[] { start+1, end+1 };
                }
                if (sum < target)
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }
            return null;
        }
    }
}
