public class Solution
{
    // Class of object type 'Job'
    class Job
    {
        // Declaring variables to hold start time, end time, and profit for each job
        public int start;
        public int end;
        public int profit;

        // Constructor to initialize Job object with start time, end time, and profit
        public Job(int s, int e, int p)
        {
            start = s;
            end = e;
            profit = p;
        }
    }

    // Main function to calculate maximum profit from scheduling jobs
    public int JobScheduling(int[] startTime, int[] endTime, int[] profit)
    {
        // Get the number of jobs
        int numJobs = startTime.Length;
        // Create a list to hold Job objects
        List<Job> jobs = new List<Job>();

        // Iterate over each job and create Job objects with start time, end time, and profit
        for (int i = 0; i < numJobs; i++)
        {
            jobs.Add(new Job(startTime[i], endTime[i], profit[i]));
        }

        // Sort the jobs based on their end times
        jobs.Sort((a, b) => a.end - b.end);

        // Initialize an array to store the maximum profit for each job
        int[] maxProfitSoFar = new int[numJobs];
        // Set the initial maximum profit for the first job
        maxProfitSoFar[0] = jobs[0].profit;

        // Iterate over each job
        for (int index = 1; index < numJobs; index++)
        {
            // Get the profit of the current job
            int currentProfit = jobs[index].profit;
            // Find the index of the last compatible job using binary search
            int lastCompatibleJob = BinarySearch(jobs, index);

            // If there exists a compatible job
            if (lastCompatibleJob != -1)
            {
                // Add the profit of the last compatible job to the current profit
                currentProfit += maxProfitSoFar[lastCompatibleJob];
            }

            // Store the maximum profit either including or excluding the current job
            maxProfitSoFar[index] = Math.Max(currentProfit, maxProfitSoFar[index - 1]);
        }

        // Return the maximum profit achievable by scheduling jobs
        return maxProfitSoFar[numJobs - 1];
    }

    // Function to perform binary search to find the last compatible job
    int BinarySearch(List<Job> jobs, int index)
    {
        // Initialize left and right pointers for binary search
        int left = 0;
        int right = index - 1;

        // Perform binary search
        while (left <= right)
        {
            // Calculate mid index
            int mid = left + (right - left) / 2;

            // If the end time of the mid job is less than or equal to the start time of the current job
            if (jobs[mid].end <= jobs[index].start)
            {
                // If the end time of the next job after mid is greater than the start time of the current job
                if (jobs[mid + 1].end > jobs[index].start)
                {
                    // Return the index of the last compatible job
                    return mid;
                }
                // Update left pointer
                left = mid + 1;
            }
            else
            {
                // Update right pointer
                right = mid - 1;
            }
        }
        // Return -1 if no compatible job is found
        return -1;
    }
}
