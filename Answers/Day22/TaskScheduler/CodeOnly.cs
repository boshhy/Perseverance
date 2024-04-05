public class Solution
{
    public int LeastInterval(char[] tasks, int n)
    {
        int[] counts = new int[26];
        foreach (char letter in tasks)
        {
            counts[letter - 'A']++;
        }

        Array.Sort(counts);

        int maxTaskCount = counts[25] - 1;
        int idle_slots = maxTaskCount * n;

        for (int i = 24; i >= 0; i--)
        {
            idle_slots = idle_slots - Math.Min(counts[i], maxTaskCount);
        }

        return idle_slots > 0 ? idle_slots + tasks.Length : tasks.Length;
    }
}