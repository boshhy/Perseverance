public class Solution
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        // If the starting pixel color is already the new color, return the image
        if (image[sr][sc] == color)
        {
            return image;
        }

        // Perform flood fill starting from the starting pixel
        PaintTheCanvas(image, sr, sc, color, image.Length, image[0].Length, image[sr][sc]);

        // Return the modified image after flood fill
        return image;
    }

    // Helper method to perform recursive flood fill
    public void PaintTheCanvas(int[][] image, int sr, int sc, int newColor, int srLength, int scLength, int baseColor)
    {
        // Check if the current pixel is out of bounds 
        if (sr < 0 || sr >= srLength || sc < 0 || sc >= scLength)
            return;

        // Check if the current pixel color is already the new color or different from the base color
        if (image[sr][sc] == newColor || image[sr][sc] != baseColor)
            return;

        // Change the color of the current pixel to the new color
        image[sr][sc] = newColor;

        // Recursively visit the adjacent pixels in all four directions
        PaintTheCanvas(image, sr + 1, sc, newColor, srLength, scLength, baseColor); // Down
        PaintTheCanvas(image, sr - 1, sc, newColor, srLength, scLength, baseColor); // Up
        PaintTheCanvas(image, sr, sc + 1, newColor, srLength, scLength, baseColor); // Right
        PaintTheCanvas(image, sr, sc - 1, newColor, srLength, scLength, baseColor); // Left
    }
}
