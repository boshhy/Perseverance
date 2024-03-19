public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int max = nums[0];
        int currentSum = nums[0];

        foreach (int num in nums.AsSpan(1))
        {
            currentSum = Math.Max(currentSum + num, num);
            max = Math.Max(currentSum, max);
        }

        return max;
    }
}