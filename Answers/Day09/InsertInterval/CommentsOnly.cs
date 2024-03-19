// Overview
public class Solution
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        // The code is merging intervals in a list with a new interval by finding overlapping intervals 
        // and combining them. It iterates through the intervals to find those that do not overlap 
        // with the new interval and adds them to the result list. Then, it merges overlapping intervals with 
        // the new interval, updates its start and end accordingly, and adds it to the result list. 
        // Finally, it adds any remaining intervals to the result list and returns the merged list of intervals.
    }
}

// Comments
public class Solution
{
    // Method to insert a new interval into a list of intervals
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        // Create a list to hold the resulting intervals
        // Initialize a pointer to iterate through the intervals

        // Loop through intervals until reaching the end or finding a non-overlapping interval
        //     Add intervals that do not overlap with the new interval
        //     Move to the next interval

        // Loop through intervals that overlap with the new interval
        //     Update the start and end of the new interval to cover the overlapping intervals
        //     Move to the next interval

        // Add the merged interval to the result list

        // Add the remaining intervals that do not overlap with the new interval

        // Convert the list of intervals to an array and return
    }
}

// Pseudocode
public class Solution
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        // result = empty list
        // i = 0

        // while i < length(intervals) and intervals[i][1] < newInterval[0]:
        //     result.append(intervals[i])
        //     i = i + 1

        // while i < length(intervals) and newInterval[1] >= intervals[i][0]:
        //     newInterval[0] = min(intervals[i][0], newInterval[0])
        //     newInterval[1] = max(intervals[i][1], newInterval[1])
        //     i = i + 1

        // result.append(newInterval)

        // while i < length(intervals):
        //     result.append(intervals[i])
        //     i = i + 1

        // return result
    }
}