// Overview
public class Solution
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        // This code implements a method SpiralOrder that takes a 2D matrix as input and returns its elements in a spiral order. 
        // It initializes four variables to keep track of the boundaries of the matrix: north, south, west, and east. 
        // Then, it iterates through the matrix in a spiral pattern, adding elements to a result list. The iteration progresses 
        // by traversing the top row, right column, bottom row, and left column of the matrix, adjusting the boundaries accordingly. 
        // Finally, it returns the list containing the elements in spiral order.
    }
}

// Comments
public class Solution
{
    // Method to traverse a 2D matrix in spiral order and return the elements in a list
    public IList<int> SpiralOrder(int[][] matrix)
    {
        // Define variables to keep track of boundaries in the matrix
        // Northern boundary
        // Southern boundary
        // Western boundary
        // Eastern boundary

        // Create a list to store the elements traversed in spiral order

        // Continue traversal until all elements are visited
        //     Traverse from west to east along the northern boundary
        //         Add the element at the current position to the result list
        //     Move the northern boundary down

        //     Traverse from north to south along the eastern boundary
        //         Add the element at the current position to the result list
        //     Move the eastern boundary inward

        //     If there are more rows to traverse (north and south boundaries have not crossed)
        //         Traverse from east to west along the southern boundary
        //             Add the element at the current position to the result list
        //     Move the southern boundary up

        //     If there are more columns to traverse (west and east boundaries have not crossed)
        //         Traverse from south to north along the western boundary
        //             Add the element at the current position to the result list
        //     Move the western boundary inward

        // Return the list containing elements traversed in spiral order
    }
}

// Pseudocode
public class Solution
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        // north = 0
        // south = matrix.length - 1
        // west = 0
        // east = matrix[0].length - 1
        // result = []

        // while (north <= south AND west <= east):
        //     for w from west to east:
        //         result.append(matrix[north][w])
        //     north++

        //     for n from north to south:
        //         result.append(matrix[n][east])
        //     east--

        //     if (north <= south):
        //         for e from east to west:
        //             result.append(matrix[south][e])
        //     south--

        //     if (west <= east):
        //         for s from south to north:
        //             result.append(matrix[s][west])
        //     west++

        // return result
    }
}


