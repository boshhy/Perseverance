// Overview
public class Solution
{
    // This solution implements a flood fill algorithm to change the color of connected pixels in an image grid. 
    public int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        // The FloodFill method checks if the starting pixel already has the desired color; 
        // if not, it calls the PaintTheCanvas method to perform the flood fill operation. 
        // PaintTheCanvas method recursively visits adjacent pixels, changing their color if they meet certain conditions. 
        // This process continues until all connected pixels with the same initial color are modified to the new color. 
        // Finally, the modified image is returned.
    }
}

// Comments
public class Solution
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        // If the starting pixel color is already the new color, return the image

        // Perform flood fill starting from the starting pixel

        // Return the modified image after flood fill
    }

    // Helper method to perform recursive flood fill
    // {
    //     Check if the current pixel is out of bounds

    //     Check if the current pixel color is already the new color or different from the base color

    //     Change the color of the current pixel to the new color

    //     Recursively visit the adjacent pixels in all four directions: Down, Up, Right, Left
    // }
}

// Pseudocode
public class Solution
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        // if image[sr][sc] == color:
        //     return image
        // PaintTheCanvas(image, sr, sc, color, image.Length, image[0].Length, image[sr][sc])
        // return image
    }

    // PaintTheCanvas(image, sr, sc, newColor, srLength, scLength, baseColor):
    // {
    //     if sr < 0 or sr >= srLength or sc < 0 or sc >= scLength:
    //         return
    //     if image[sr][sc] == newColor or image[sr][sc] != baseColor:
    //         return
    //     image[sr][sc] = newColor
    //     PaintTheCanvas(image, sr + 1, sc, newColor, srLength, scLength, baseColor)
    //     PaintTheCanvas(image, sr - 1, sc, newColor, srLength, scLength, baseColor)
    //     PaintTheCanvas(image, sr, sc + 1, newColor, srLength, scLength, baseColor)
    //     PaintTheCanvas(image, sr, sc - 1, newColor, srLength, scLength, baseColor)
    // }
}
