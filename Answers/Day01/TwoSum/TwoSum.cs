public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        // This method takes an array of integers 'nums' and an integer 'target' as parameters
        // and returns an array containing the indices of the two numbers whose sum equals the target.

        // Initialize a dictionary to store the numbers already visited along with their indices.
        Dictionary<int, int> pastNumbers = new Dictionary<int, int>();

        // Declare a variable to store the difference between the target and the current number.
        int difference;

        // Loop through each number in the array 'nums'. 
        for (int i = 0; i < nums.Length; i++)
        {
            // Calculate the difference needed to reach the target from the current number.
            difference = target - nums[i];

            // Check if the difference exists in the 'pastNumbers' dictionary.
            if (pastNumbers.ContainsKey(difference))
            {
                // If the difference exists, return the indices of the current number and the difference.
                return new int[] { i, pastNumbers[difference] };
            }

            /*
            In terms of performance, 
            pastNumbers[nums[i]] = i is generally faster than 
            pastNumbers.Add(nums[i], i) because it directly sets 
            the value for a given key without any additional checks for existence.
            */

            // Add the current number and its index to the 'pastNumbers' dictionary.
            pastNumbers[nums[i]] = i;
        }

        // If no two numbers add up to the target, return an empty array.
        return new int[0];
    }
}