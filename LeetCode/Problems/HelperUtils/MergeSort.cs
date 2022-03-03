namespace Problems.HelperUtils
{
    internal class MergeSort
    {
        public static void Sort(int[] nums,int left,int right)
        {
            if(left < right)
            {
                var mid = left + (right-left)/2;
                Sort(nums,left,mid);
                Sort(nums,mid + 1, right);
                Merge(nums, left, mid, right);
            }
        }
        private static void Merge(int[] nums, int left, int mid, int right)
        {
            int n1 = mid-left+1;
            int n2 = right-mid;

            var a1 = new int[n1];
            var a2 = new int[n2];

            for(int i = 0; i < n1; i++)
            {
                a1[i] = nums[left+i];
            }
            for(int j = 0; j < n2; j++)
            {
                a2[j] = nums[mid+1+j];
            }

            int i1 = 0,j1 = 0,k1 = left;

            while(i1 < n1 && j1 < n2)
            {
                if(a1[i1] < a2[j1])
                {
                    nums[k1++]=a1[i1++];
                }
                else
                {
                    nums[k1++] = a2[j1++];
                }
            }

            while(i1 < n1)
            {
                nums[k1++] = a1[i1++];
            }
            while (j1 < n2)
            {
                nums[k1++] = a2[j1++];
            }
        }
    }
}
