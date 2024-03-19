public class Solution
{
    // Method to insert a new interval into a list of intervals
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        // Create a list to hold the resulting intervals
        List<int[]> result = new List<int[]>();
        // Initialize a pointer to iterate through the intervals
        int i = 0;

        // Loop through intervals until reaching the end or finding a non-overlapping interval
        while (i < intervals.Length && intervals[i][1] < newInterval[0])
        {
            // Add intervals that do not overlap with the new interval
            result.Add(intervals[i]);
            // Move to the next interval
            i++;
        }

        // Loop through intervals that overlap with the new interval
        while (i < intervals.Length && newInterval[1] >= intervals[i][0])
        {
            // Update the start and end of the new interval to cover the overlapping intervals
            newInterval[0] = Math.Min(intervals[i][0], newInterval[0]);
            newInterval[1] = Math.Max(intervals[i][1], newInterval[1]);
            // Move to the next interval
            i++;
        }

        // Add the merged interval to the result list
        result.Add(newInterval);

        // Add the remaining intervals that do not overlap with the new interval
        while (i < intervals.Length)
        {
            result.Add(intervals[i]);
            i++;
        }

        // Convert the list of intervals to an array and return
        return result.ToArray();
    }
}
