namespace Problems
{
    internal class FloodFillSolution
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            var oldColor = image[sr][sc];
            image[sr][sc] = newColor;
            image = FloodFillRecursive(image, sr + 1, sc, newColor, oldColor);
            image = FloodFillRecursive(image, sr - 1, sc, newColor, oldColor);
            image = FloodFillRecursive(image, sr, sc + 1, newColor, oldColor);
            image = FloodFillRecursive(image, sr, sc - 1, newColor, oldColor);
            return image;
        }
        public int[][] FloodFillRecursive(int[][] image, int sr, int sc, int newColor, int oldColor)
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
            image = FloodFillRecursive(image, sr+1, sc, newColor, oldColor);
            image = FloodFillRecursive(image, sr-1, sc, newColor, oldColor);
            image = FloodFillRecursive(image, sr, sc+1, newColor, oldColor);
            image = FloodFillRecursive(image, sr, sc-1, newColor, oldColor);
            return image;

        }
    }
}
