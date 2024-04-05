// Overview 
public class Solution
{
    public int LeastInterval(char[] tasks, int n)
    {
        // The code calculates the minimum intervals needed to execute tasks with a cooldown period 'n' between 
        // identical tasks. It counts the frequency of each task, sorts them, determines the maximum task frequency, 
        // calculates the idle slots based on it, and adjusts for tasks with lower frequencies. 
        // Finally, it returns the total intervals required considering the idle slots and the length of the tasks array.
    }
}

// Comments 
public class Solution
{
    // Method to calculate the least intervals required for executing tasks
    public int LeastInterval(char[] tasks, int n)
    {
        // Array to store the count of each task of size 26 assuming only capital English letters are used in tasks

        // Counting the occurrences of each task
        // Converting char to its corresponding index in the counts array

        // Sorting the counts array to get the maximum task count

        // Calculating the maximum frequency of the most frequent task (subtracting 1 because it doesn't need to be idle for the last time)

        // Calculating idle slots based on the maximum frequency task

        // Iterating through tasks with frequency less than the maximum frequency task
        // Subtracting the minimum of the task frequency or the maximum task count from the idle slots

        // Returning the total number of intervals required
        // If idle slots are positive, adding it to the total tasks length
    }
}

// Pseudocode 
public class Solution
{
    public int LeastInterval(char[] tasks, int n)
    {
        // Initialize an array 'counts' of size 26 to store the count of each task.

        // For each task 'letter' in 'tasks':
        //     Increment the count of 'letter' in 'counts' array.

        // Sort the 'counts' array in ascending order.

        // Calculate 'maxTaskCount' as the frequency of the task with the maximum count minus 1.

        // Calculate 'idle_slots' as 'maxTaskCount' multiplied by 'n'.

        // For each task count in 'counts' array starting from the second highest count:
        //     Subtract the minimum of the task count and 'maxTaskCount' from 'idle_slots'.

        // Return 'idle_slots' plus 'tasks.Length' if 'idle_slots' is positive, otherwise return 'tasks.Length'.
    }
}
