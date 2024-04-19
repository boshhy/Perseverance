class Solution
{
    class Job
    {
        public int start;
        public int end;
        public int profit;

        public Job(int s, int e, int p)
        {
            start = s;
            end = e;
            profit = p;
        }
    }

    public int JobScheduling(int[] startTime, int[] endTime, int[] profit)
    {
        int n = startTime.Length;

        List<Job> jobs = new List<Job>();
        for (int i = 0; i < n; i++)
        {
            jobs.Add(new Job(startTime[i], endTime[i], profit[i]));
        }

        jobs.Sort((a, b) => a.end - b.end);

        int[] dp = new int[n];
        dp[0] = jobs[0].profit;

        for (int i = 1; i < n; i++)
        {
            int currentProfit = jobs[i].profit;
            int lastCompatibleJob = BinarySearch(jobs, i);

            if (lastCompatibleJob != -1)
            {
                currentProfit += dp[lastCompatibleJob];
            }

            dp[i] = Math.Max(currentProfit, dp[i - 1]);
        }

        return dp[n - 1];

        int BinarySearch(List<Job> jobs, int index)
        {
            int low = 0, high = index - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (jobs[mid].end <= jobs[index].start)
                {
                    if (jobs[mid + 1].end <= jobs[index].start)
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        return mid;
                    }
                }
                else
                {
                    high = mid - 1;
                }
            }
            return -1;
        }
    }

}