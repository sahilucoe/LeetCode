namespace Problems
{
    /* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

    public class FirstBadVersionSolution : VersionControl
    {
        public int FirstBadVersion(int n)
        {
            return FirstBadVersion(1, n);
        }

        public int FirstBadVersion(int start, int end)
        {
            var mid = start + (end - start) / 2;
            if (IsBadVersion(mid))
            {
                if (!IsBadVersion(mid - 1))
                {
                    return mid;
                }
                else
                {
                    return FirstBadVersion(start, mid - 1);
                }

            }
            else
            {
                return FirstBadVersion(mid + 1, end);
            }
        }
    }

    public class VersionControl
    {
        // dummy
        public bool IsBadVersion(int version) => true;
    }
}
