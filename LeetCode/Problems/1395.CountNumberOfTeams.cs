namespace Problems
{
    internal class CountNumberOfTeams
    {
        public int NumTeams(int[] rating)
        {
            int[] greaterOnRight = new int[rating.Length];
            int[] smallerOnRight = new int[rating.Length];

            greaterOnRight[rating.Length - 1] = 0;
            smallerOnRight[rating.Length - 1] = 0;

            for (var i = 0; i < rating.Length; i++)
            {
                for (var j = i; j < rating.Length; j++)
                {
                    if (rating[j] > rating[i])
                    {
                        greaterOnRight[i]++;
                    }
                    else if (rating[j] < rating[i])
                    {
                        smallerOnRight[i]++;
                    }
                }
            }
            var total = 0;

            for (int i = 0; i < rating.Length; i++)
            {
                for (var j = i + 1; j < rating.Length; j++)
                {
                    if (rating[j] > rating[i])
                    {
                        total += greaterOnRight[j];
                    }
                }
            }
            for (int i = 0; i < rating.Length; i++)
            {
                for (var j = i + 1; j < rating.Length; j++)
                {
                    if (rating[j] < rating[i])
                    {
                        total += smallerOnRight[j];
                    }
                }
            }
            return total;
        }
    }
}
