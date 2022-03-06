using System.Collections.Generic;

namespace Problems
{
    internal class PascalTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var output = new List<IList<int>>();
            output.Add(new List<int>() { 1});
            if (numRows > 1)
            {
                output.Add(new List<int>() { 1,1 });
            }

            for(int i = 3; i <= numRows; i++)
            {
                var l = new List<int>();
                l.Add(1);
                for(var j = 0; j < output[output.Count-1].Count-1; j++)
                {
                    l.Add(output[output.Count - 1][j] + output[output.Count - 1][j + 1]);
                }
                l.Add(1);
                output.Add(l);
            }
            return output;
        }
    }
}
