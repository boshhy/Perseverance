public class Solution
{
    // Method to merge overlapping intervals
    public int[][] Merge(int[][] intervals)
    {
        // Sorting intervals based on the start time of each interval
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        // Initializing variables to store lower and higher bounds of intervals
        int lower = intervals[0][0];
        int higher = intervals[0][1];

        // Initializing a list to store the merged intervals
        List<int[]> result = new List<int[]>();

        // Iterating through each interval
        for (int i = 0; i < intervals.Length; i++)
        {
            // Checking if the end time of the current interval is less than the start time of the next interval
            if (higher < intervals[i][0])
            {
                // If there is no overlap, adding the merged interval to the result list
                result.Add([lower, higher]);
                // Updating lower and higher bounds for the next interval
                lower = intervals[i][0];
                higher = intervals[i][1];
            }
            // Updating the higher bound if necessary
            higher = Math.Max(higher, intervals[i][1]);
        }
        // Adding the last merged interval to the result list
        result.Add([lower, higher]);

        // Converting the list of merged intervals to a 2D array and returning it
        return result.ToArray();
    }
}
