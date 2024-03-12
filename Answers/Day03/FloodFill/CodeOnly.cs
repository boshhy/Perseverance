public class Solution
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        if (image[sr][sc] == color)
        {
            return image;
        }

        PaintTheCanvas(image, sr, sc, color, image.Length, image[0].Length, image[sr][sc]);

        return image;
    }

    public void PaintTheCanvas(int[][] image, int sr, int sc, int newColor, int srLength, int scLength, int baseColor)
    {
        if (sr < 0 || sr >= srLength || sc < 0 || sc >= scLength)
            return;

        if (image[sr][sc] == newColor || image[sr][sc] != baseColor)
            return;

        image[sr][sc] = newColor;

        PaintTheCanvas(image, sr + 1, sc, newColor, srLength, scLength, baseColor);
        PaintTheCanvas(image, sr - 1, sc, newColor, srLength, scLength, baseColor);
        PaintTheCanvas(image, sr, sc + 1, newColor, srLength, scLength, baseColor);
        PaintTheCanvas(image, sr, sc - 1, newColor, srLength, scLength, baseColor);
    }
}