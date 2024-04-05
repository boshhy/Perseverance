public class Solution
{
    // Method to calculate the least intervals required for executing tasks
    public int LeastInterval(char[] tasks, int n)
    {
        // Array to store the count of each task
        int[] counts = new int[26]; // Assuming only capital English letters are used in tasks

        // Counting the occurrences of each task
        foreach (char letter in tasks)
        {
            counts[letter - 'A']++; // Converting char to its corresponding index in the counts array
        }

        // Sorting the counts array to get the maximum task count
        Array.Sort(counts);

        // Calculating the maximum frequency of the most frequent task
        int maxTaskCount = counts[25] - 1; // Max frequency of the most frequent task (subtracting 1 because it doesn't need to be idle for the last time)

        // Calculating idle slots based on the maximum frequency task
        int idle_slots = maxTaskCount * n;

        // Iterating through tasks with frequency less than the maximum frequency task
        for (int i = 24; i >= 0; i--)
        {
            // Subtracting the minimum of the task frequency or the maximum task count from the idle slots
            idle_slots = idle_slots - Math.Min(counts[i], maxTaskCount);
        }

        // Returning the total number of intervals required
        // If idle slots are positive, adding it to the total tasks length
        return idle_slots > 0 ? idle_slots + tasks.Length : tasks.Length;
    }
}
