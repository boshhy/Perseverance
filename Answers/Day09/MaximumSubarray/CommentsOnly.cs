// Overview
public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        // It initializes max and currentSum to the first element of the array, then iterates through 
        // the array starting from the second element. In each iteration, it updates currentSum to be 
        // the maximum of the sum of the current element and the previous sum or just the current 
        // element itself, and updates max to be the maximum of currentSum and max. 
        // Finally, it returns the maximum subarray sum found (max).
    }
}

// Comments
public class Solution
{
    // Method to find the maximum subarray sum
    public int MaxSubArray(int[] nums)
    {
        // Initialize max to the first element of the array
        // Initialize currentSum to the first element of the array

        // Iterate through the array starting from the second element
        //     Update currentSum to the maximum of the sum of current element and previous sum or the current element itself
        //     Update max to the maximum of currentSum and max

        // Return the maximum subarray sum
    }
}

// Pseudocode
public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        // max = nums[0]
        // currentSum = nums[0]

        // for num in nums[1:]:
        //     currentSum = max(currentSum + num, num)
        //     max = max(currentSum, max)

        // return max
    }
}