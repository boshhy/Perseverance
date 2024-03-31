public class Solution
{
    public int UniquePaths(int m, int n)
    {
        Dictionary<(int, int), int> grid = new Dictionary<(int, int), int>();

        for (int row = 0; row < m; row++)
        {
            grid[(row, 0)] = 1;
        }

        for (int column = 0; column < n; column++)
        {
            grid[(0, column)] = 1;
        }

        for (int row = 1; row < m; row++)
        {
            for (int column = 1; column < n; column++)
            {
                grid[(row, column)] = grid[(row - 1, column)] + grid[(row, column - 1)];
            }
        }

        return grid[(m - 1, n - 1)];
    }
}
