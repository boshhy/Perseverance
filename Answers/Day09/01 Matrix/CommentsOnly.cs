// Overview
public class Solution
{
    // Method to update the matrix with distances from nearest 0
    public int[][] UpdateMatrix(int[][] mat)
    {
        // It iterates through the matrix twice, first from top-left to bottom-right, 
        // and then from bottom-right to top-left, 
        // updating each cell's distance based on the minimum distance from neighboring cells. 
        // Finally, it returns the updated matrix.
    }
}

// Comments
public class Solution
{
    // Method to update the matrix with distances from nearest 0
    public int[][] UpdateMatrix(int[][] mat)
    {
        // Get the number of rows in the matrix
        // Get the number of columns in the matrix
        // Calculate the maximum possible distance in the matrix

        // Iterate through each cell in the matrix
        //         If the current cell contains 0, skip it

        //         Initialize top and left distances to maximum

        //         Update top distance if there's a non-zero cell above

        //         Update left distance if there's a non-zero cell on the left

        //         Update the current cell with the minimum distance from top or left plus 1

        // Iterate through each cell in reverse order
        //         If the current cell contains 0, skip it

        //         Initialize bottom and right distances to maximum

        //         Update bottom distance if there's a non-zero cell below

        //         Update right distance if there's a non-zero cell on the right

        //         Update the current cell with the minimum distance from bottom, right, or current value plus 1
        // Return the updated matrix
    }
}


// Pseudocode
public class Solution
{
    public int[][] UpdateMatrix(int[][] mat)
    {
        // rowLength = length(mat)
        // columnLength = length(mat[0])
        // max = rowLength + columnLength

        // for row = 0 to rowLength - 1:
        //     for column = 0 to columnLength - 1:
        //         if mat[row][column] == 0:
        //             continue

        //         top = max
        //         left = max

        //         if row > 0:
        //             top = mat[row - 1][column]

        //         if column > 0:
        //             left = mat[row][column - 1]

        //         mat[row][column] = min(top, left) + 1

        // for row = rowLength - 1 down to 0:
        //     for column = columnLength - 1 down to 0:
        //         if mat[row][column] == 0:
        //             continue

        //         bottom = max
        //         right = max

        //         if row < rowLength - 1:
        //             bottom = mat[row + 1][column]

        //         if column < columnLength - 1:
        //             right = mat[row][column + 1]

        //         mat[row][column] = min(mat[row][column], min(bottom, right) + 1)

        // return mat
    }
}