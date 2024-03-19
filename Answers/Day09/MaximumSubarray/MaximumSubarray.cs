public class Solution
{
    // Method to find the maximum subarray sum
    public int MaxSubArray(int[] nums)
    {
        // Initialize max to the first element of the array
        int max = nums[0];
        // Initialize currentSum to the first element of the array
        int currentSum = nums[0];

        // Iterate through the array starting from the second element
        foreach (int num in nums.AsSpan(1))
        {
            // Update currentSum to the maximum of the sum of current element and previous sum or the current element itself
            currentSum = Math.Max(currentSum + num, num);
            // Update max to the maximum of currentSum and max
            max = Math.Max(currentSum, max);
        }

        // Return the maximum subarray sum
        return max;
    }
}
