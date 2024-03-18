public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        // Create a HashSet to store unique integers
        HashSet<int> uniqueNumbers = new HashSet<int>();

        // Iterate through each element in the input array
        for (int i = 0; i < nums.Length; i++)
        {
            // Attempt to add the current number to the HashSet; if it already exists, Add() returns false
            if (!uniqueNumbers.Add(nums[i]))
            {
                // If the number already exists in the HashSet, return true indicating a duplicate is found
                return true;
            }
        }
        // If the loop completes without finding any duplicates, return false
        return false;
    }
}
