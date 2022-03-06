using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    internal class ThreeSumSolution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var set = new HashSet<Tuple<int, int, int>>();
            Array.Sort(nums);

            for (var i = 0; i < nums.Length; i++)
            {
                int start = i + 1, end = nums.Length - 1;
                while (start < end)
                {
                    if (nums[start] + nums[end] + nums[i] == 0)
                    {
                        set.Add(new Tuple<int, int, int>(nums[i], nums[start], nums[end]));
                        start++;
                        end--;
                    }
                    else if (nums[start] + nums[end] + nums[i] > 0)
                    {
                        end--;
                    }
                    else
                    {
                        start++;
                    }
                }
            }
            return set.Select(x=> (IList<int>)new List<int> {x.Item1,x.Item2,x.Item3 }).ToList();
        }
    }
}
