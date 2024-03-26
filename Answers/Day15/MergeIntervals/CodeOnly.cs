public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        int lower = intervals[0][0];
        int higher = intervals[0][1];

        List<int[]> result = new List<int[]>();

        for (int i = 0; i < intervals.Length; i++)
        {
            if (higher < intervals[i][0])
            {
                result.Add([lower, higher]);
                lower = intervals[i][0];
                higher = intervals[i][1];
            }
            higher = Math.Max(higher, intervals[i][1]);
        }
        result.Add([lower, higher]);

        return result.ToArray();
    }
}