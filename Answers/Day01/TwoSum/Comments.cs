// Overview
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        // This code finds indices of two numbers in an array whose sum equals a target. 
        // It initializes a dictionary to store visited numbers and their indices, 
        // then iterates through the array. If the difference between the target 
        // and the current number exists in the dictionary, it returns their indices. 
    }
}

// Comments
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        // This method takes an array of integers 'nums' and an integer 'target' as parameters 
        // and returns an array containing the indices of the two numbers whose sum equals the target.

        // Initialize a dictionary to store the numbers already visited along with their indices.

        // Declare a variable to store the difference between the target and the current number.

        // Loop through each number in the array 'nums'.

        //      Calculate the difference needed to reach the target from the current number.

        //      Check if the difference exists in the 'pastNumbers' dictionary.

        //       If the difference exists, return the indices of the current number and the difference.

        //       /*
        //       In terms of performance, 
        //       pastNumbers[nums[i]] = i is generally faster than 
        //       pastNumbers.Add(nums[i], i) because it directly sets 
        //       the value for a given key without any additional checks for existence.
        //       */

        //      Add the current number and its index to the 'pastNumbers' dictionary.

        //  If no two numbers add up to the target, return an empty array.
    }
}

// Pseudocode
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        // Initialize an empty dictionary called 'pastNumbers'
        // Declare a variable called 'difference'

        // For each number 'num' in the 'nums' array, do:
        //     Set 'difference' to be the difference between 'target' and 'num'

        //     If 'difference' is found in 'pastNumbers', do:
        //         Return an array containing the current index and the index of 'difference' stored in 'pastNumbers'

        //     Store the current index of 'num' in 'pastNumbers'

        // Return an empty array if no two numbers add up to the target
    }
}