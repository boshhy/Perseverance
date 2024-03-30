public class Solution
{
    // Method to traverse a 2D matrix in spiral order and return the elements in a list
    public IList<int> SpiralOrder(int[][] matrix)
    {
        // Define variables to keep track of boundaries in the matrix
        int north = 0; // Northern boundary
        int south = matrix.Length - 1; // Southern boundary
        int west = 0; // Western boundary
        int east = matrix[0].Length - 1; // Eastern boundary

        // Create a list to store the elements traversed in spiral order
        IList<int> result = new List<int>();

        // Continue traversal until all elements are visited
        while (north <= south && west <= east)
        {
            // Traverse from west to east along the northern boundary
            for (int w = west; w <= east; w++)
            {
                // Add the element at the current position to the result list
                result.Add(matrix[north][w]);
            }
            // Move the northern boundary down
            north++;

            // Traverse from north to south along the eastern boundary
            for (int n = north; n <= south; n++)
            {
                // Add the element at the current position to the result list
                result.Add(matrix[n][east]);
            }
            // Move the eastern boundary inward
            east--;

            // If there are more rows to traverse (north and south boundaries have not crossed)
            if (north <= south)
            {
                // Traverse from east to west along the southern boundary
                for (int e = east; e >= west; e--)
                {
                    // Add the element at the current position to the result list
                    result.Add(matrix[south][e]);
                }
            }
            // Move the southern boundary up
            south--;

            // If there are more columns to traverse (west and east boundaries have not crossed)
            if (west <= east)
            {
                // Traverse from south to north along the western boundary
                for (int s = south; s >= north; s--)
                {
                    // Add the element at the current position to the result list
                    result.Add(matrix[s][west]);
                }
            }
            // Move the western boundary inward
            west++;
        }

        // Return the list containing elements traversed in spiral order
        return result;
    }
}
