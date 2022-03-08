using System;

namespace Problems
{
    internal class MaxAreaOfIslandSolution
    {
        private static int area = 0;
        public int MaxAreaOfIsland(int[][] grid)
        {
            var max = 0;
            for(int i = 0; i < grid.Length; i++)
            {
                for(int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        grid = FloodFill(grid, i, j, 2);
                        max = Math.Max(max, area);
                    }
                }
            }
            return max;
        }
        private int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            area = 1;
            var oldColor = image[sr][sc];
            image[sr][sc] = newColor;
            image = FloodFillRecursive(image, sr + 1, sc, newColor, oldColor);
            image = FloodFillRecursive(image, sr - 1, sc, newColor, oldColor);
            image = FloodFillRecursive(image, sr, sc + 1, newColor, oldColor);
            image = FloodFillRecursive(image, sr, sc - 1, newColor, oldColor);
            return image;
        }
        private int[][] FloodFillRecursive(int[][] image, int sr, int sc, int newColor, int oldColor)
        {
            if (oldColor == newColor)
                return image;
            if (sr < 0 || sc < 0)
                return image;
            if (sr >= image.Length || sc >= image[0].Length)
                return image;
            if (image[sr][sc] != oldColor)
            {
                return image;
            }
            image[sr][sc] = newColor;
            area++;
            image = FloodFillRecursive(image, sr + 1, sc, newColor, oldColor);
            image = FloodFillRecursive(image, sr - 1, sc, newColor, oldColor);
            image = FloodFillRecursive(image, sr, sc + 1, newColor, oldColor);
            image = FloodFillRecursive(image, sr, sc - 1, newColor, oldColor);
            return image;

        }
    }
}
