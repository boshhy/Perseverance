public class Solution
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        int north = 0;
        int south = matrix.Length - 1;
        int west = 0;
        int east = matrix[0].Length - 1;
        IList<int> result = new List<int>();

        while (north <= south && west <= east)
        {

            for (int w = west; w <= east; w++)
            {
                result.Add(matrix[north][w]);
            }
            north++;


            for (int n = north; n <= south; n++)
            {
                result.Add(matrix[n][east]);
            }
            east--;

            if (north <= south)
            {
                for (int e = east; e >= west; e--)
                {
                    result.Add(matrix[south][e]);
                }
            }
            south--;

            if (west <= east)
            {
                for (int s = south; s >= north; s--)
                {
                    result.Add(matrix[s][west]);
                }
            }
            west++;
        }

        return result;
    }
}