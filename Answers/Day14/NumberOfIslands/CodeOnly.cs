public class Solution
{
    public int NumIslands(char[][] grid)
    {
        int totalIslands = 0;

        for (int row = 0; row < grid.Length; row++)
        {
            for (int column = 0; column < grid[0].Length; column++)
            {
                if (grid[row][column] == '1')
                {
                    totalIslands++;
                    VisitIsland(row, column);
                }
            }
        }

        return totalIslands;

        void VisitIsland(int r, int c)
        {
            if (r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length)
            {
                return;
            }
            if (grid[r][c] == '0')
            {
                return;
            }
            grid[r][c] = '0';

            VisitIsland(r + 1, c);
            VisitIsland(r, c + 1);
            VisitIsland(r - 1, c);
            VisitIsland(r, c - 1);
        }
    }
}