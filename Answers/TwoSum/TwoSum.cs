using System;
using System.Collections.Generic;

public class TwoSumSolution
{
    public static int[] TwoSum(int[] nums, int target)
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

    static void Main(string[] args)
    {
        // Test cases to verify the TwoSum method

        // Test case 1: Example 1
        int[] nums1 = { 2, 7, 11, 15 };
        int target1 = 9;

        int[] result1 = TwoSum(nums1, target1);
        Console.WriteLine("Test case 1:");
        Console.WriteLine($"Input: nums = [{string.Join(",", nums1)}], target = {target1}");
        Console.WriteLine($"Output: [{result1[0]}, {result1[1]}]");
        Console.WriteLine("Expected output: [0, 1]");
        Console.ForegroundColor = result1.Contains(0) && result1.Contains(1) ? ConsoleColor.Green : ConsoleColor.Red;
        Console.WriteLine($"Test result: {(result1.Contains(0) && result1.Contains(1) ? "Passed" : "Failed")}");
        Console.ResetColor();

        // Test case 2: Example 2
        int[] nums2 = { 3, 2, 4 };
        int target2 = 6;

        int[] result2 = TwoSum(nums2, target2);
        Console.WriteLine("\nTest case 2:");
        Console.WriteLine($"Input: nums = [{string.Join(",", nums2)}], target = {target2}");
        Console.WriteLine($"Output: [{result2[0]}, {result2[1]}]");
        Console.WriteLine("Expected output: [1, 2]");
        Console.ForegroundColor = result2.Contains(1) && result2.Contains(2) ? ConsoleColor.Green : ConsoleColor.Red;
        Console.WriteLine($"Test result: {(result2.Contains(1) && result2.Contains(2) ? "Passed" : "Failed")}");
        Console.ResetColor();

        // Test case 3: Example 3
        int[] nums3 = { 3, 3 };
        int target3 = 6;

        int[] result3 = TwoSum(nums3, target3);
        Console.WriteLine("\nTest case 3:");
        Console.WriteLine($"Input: nums = [{string.Join(",", nums3)}], target = {target3}");
        Console.WriteLine($"Output: [{result3[0]}, {result3[1]}]");
        Console.WriteLine("Expected output: [0, 1]");
        Console.ForegroundColor = result3.Contains(0) && result3.Contains(1) ? ConsoleColor.Green : ConsoleColor.Red;
        Console.WriteLine($"Test result: {(result3.Contains(0) && result3.Contains(1) ? "Passed" : "Failed")}");
        Console.ResetColor();
    }
}