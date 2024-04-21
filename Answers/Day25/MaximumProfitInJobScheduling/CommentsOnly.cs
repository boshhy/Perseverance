// Overview
public class Solution
{
    // The Job class represents a job with attributes for its start time, end time, and associated profit, 
    // allowing for convenient organization and manipulation of job data.

    public int JobScheduling(int[] startTime, int[] endTime, int[] profit)
    {
        // The code calculates the maximum profit achievable by scheduling a set of jobs, each characterized 
        // by start time, end time, and profit. It initializes a list of Job objects, sorts them by end time, 
        // and iterates through them, calculating the maximum profit considering each job's compatibility with 
        // preceding ones using a binary search. Finally, it returns the maximum profit achievable.
    }

    // The BinarySearch function finds the index of the last compatible job within a sorted list of jobs, based on 
    // the end time of the jobs and the start time of a given job indicated by the index parameter. It utilizes binary 
    // search to efficiently locate this last compatible job and returns its index, or -1 if no compatible job is found.
}

// Comments
public class Solution
{
    // Class of object type 'Job'
    //     Declaring variables to hold start time, end time, and profit for each job

    //     Constructor to initialize Job object with start time, end time, and profit

    // Main function to calculate maximum profit from scheduling jobs
    public int JobScheduling(int[] startTime, int[] endTime, int[] profit)
    {
        // Get the number of jobs
        // Create a list to hold Job objects

        // Iterate over each job and create Job objects with start time, end time, and profit

        // Sort the jobs based on their end times


        // Initialize an array to store the maximum profit for each job
        // Set the initial maximum profit for the first job

        // Iterate over each job
        //     Get the profit of the current job
        //     Find the index of the last compatible job using binary search

        //     If there exists a compatible job
        //         Add the profit of the last compatible job to the current profit

        //     Store the maximum profit either including or excluding the current job

        // Return the maximum profit achievable by scheduling jobs
    }

    // Function to perform binary search to find the last compatible job
    //     Initialize left and right pointers for binary search

    //     Perform binary search
    //         Calculate mid index

    //         If the end time of the mid job is less than or equal to the start time of the current job
    //             If the end time of the next job after mid is greater than the start time of the current job
    //                 Return the index of the last compatible job
    //             Update left pointer
    //             Update right pointer
    //     Return -1 if no compatible job is found
}

// Pseudocode
public class Solution
{
    // class Job:
    //     int start
    //     int end
    //     int profit

    //     Job(s, e, p):
    //         start = s
    //         end = e
    //         profit = p

    public int JobScheduling(int[] startTime, int[] endTime, int[] profit)
    {
        // numJobs = length of startTime array
        // jobs = new empty list of Job objects

        // for i = 0 to numJobs - 1:
        //     create new Job object with startTime[i], endTime[i], and profit[i]
        //     add the Job object to the jobs list

        // sort the jobs list based on end time

        // maxProfitSoFar = new integer array of size numJobs
        // maxProfitSoFar[0] = profit of the first job in the sorted list

        // for index = 1 to numJobs - 1:
        //     currentProfit = profit of the job at index
        //     lastCompatibleJob = BinarySearch(jobs, index)

        //     if lastCompatibleJob != -1:
        //         currentProfit = currentProfit + maxProfitSoFar[lastCompatibleJob]

        //     maxProfitSoFar[index] = maximum of currentProfit and maxProfitSoFar[index - 1]

        // return maxProfitSoFar[numJobs - 1]
    }

    // function BinarySearch(jobs, index):
    //     left = 0
    //     right = index - 1

    //     while left <= right:
    //         mid = left + (right - left) / 2

    //         if end time of job at mid <= start time of job at index:
    //             if end time of job at mid + 1 > start time of job at index:
    //                 return mid
    //             left = mid + 1
    //         else:
    //             right = mid - 1

    //     return -1
}
