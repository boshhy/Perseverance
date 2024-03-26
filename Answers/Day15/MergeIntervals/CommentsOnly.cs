// Overview
public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        // This code merges overlapping intervals by first sorting them based on their start times. 
        // It initializes variables to track the lower and higher bounds of intervals, then iterates 
        // through the sorted intervals. If there is no overlap between the current interval and the 
        // previous one, it adds the merged interval to the result list. It updates the bounds 
        // accordingly and continues the process. 
        // Finally, it adds the last merged interval to the result list and returns it as a 2D array.
    }
}

// Comments
public class Solution
{
    // Method to merge overlapping intervals
    public int[][] Merge(int[][] intervals)
    {
        // Sorting intervals based on the start time of each interval

        // Initializing variables to store lower and higher bounds of intervals

        // Initializing a list to store the merged intervals

        // Iterating through each interval
        //     Checking if the end time of the current interval is less than the start time of the next interval
        //         If there is no overlap, adding the merged interval to the result list
        //         Updating lower and higher bounds for the next interval
        //     Updating the higher bound if necessary
        // Adding the last merged interval to the result list

        // Converting the list of merged intervals to a 2D array and returning it
    }
}

// Pseudocode
public class Solution
{
    public int[][] Merge(int[][] intervals)
    {

    }
}

// Overview
public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        // Sort intervals by the start time of each interval

        // lower = intervals[0][0]
        // higher = intervals[0][1]

        // result = empty list of intervals

        // for i from 0 to length of intervals - 1:
        //     if higher < intervals[i][0]:
        //         Add [lower, higher] to result
        //         lower = intervals[i][0]
        //         higher = intervals[i][1]
        //     higher = maximum of higher and intervals[i][1]

        // Add [lower, higher] to result

        // Return result as 2D array
    }
}