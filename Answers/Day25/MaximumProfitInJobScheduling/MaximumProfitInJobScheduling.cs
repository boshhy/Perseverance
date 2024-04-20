public class Solution
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
        int numJobs = startTime.Length;
        List<Job> jobs = new List<Job>();

        for (int i = 0; i < numJobs; i++)
        {
            jobs.Add(new Job(startTime[i], endTime[i], profit[i]));
        }

        jobs.Sort((a, b) => a.end - b.end);

        int[] maxProfitSoFar = new int[numJobs];
        maxProfitSoFar[0] = jobs[0].profit;

        for (int index = 1; index < numJobs; index++)
        {
            int currentProfit = jobs[index].profit;
            int lastCompatibleJob = BinarySearch(jobs, index);

            if (lastCompatibleJob != -1)
            {
                currentProfit += maxProfitSoFar[lastCompatibleJob];
            }

            maxProfitSoFar[index] = Math.Max(currentProfit, maxProfitSoFar[index - 1]);
        }

        return maxProfitSoFar[numJobs - 1];
    }

    int BinarySearch(List<Job> jobs, int index)
    {
        int left = 0;
        int right = index - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (jobs[mid].end <= jobs[index].start)
            {
                if (jobs[mid + 1].end > jobs[index].start)
                {
                    return mid;
                }
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return -1;
    }
}
