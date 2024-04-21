// Overview
public class Solution
{
    public int Search(int[] nums, int target)
    {
        // It initializes pointers for the left and right ends of the array and a middle index. 
        // It repeatedly narrows the search range by adjusting these pointers 
        // based on whether the target is less than or greater than the value at the middle index. 
        // If the target is found, the function returns the index of the target;  
        // otherwise, it returns -1 if the target is not present in the array.
    }
}

// Comments
public class Solution
{
    public int Search(int[] nums, int target)
    {
        // Calculate the initial middle index of the array

        // Set the initial left pointer to the beginning of the array

        // Set the initial right pointer to the end of the array

        // Begin binary search loop while the left pointer is less than or equal to the right pointer
        //     Check if the target value is found at the current middle index

        //     If the target is less than the value at the current middle index,
        //     adjust the right pointer to search the left subarray

        //     Else the target is greater than the value at the current middle index,
        //     adjust the left pointer to search the right subarray

        //     Recalculate the middle index to narrow the search range

        // If the target is not found in the array, return -1
    }
}

// Pseudocode
public class Solution
{
    public int Search(int[] nums, int target)
    {
        // Set middle to the length of nums divided by 2.
        // Set left to 0.
        // Set right to the length of nums minus 1.
        // While left is less than or equal to right:
        //     a. If target is equal to nums[middle], return middle.
        //     b. If target is less than nums[middle], set right to middle - 1.
        //     c. Otherwise, set left to middle + 1.
        //     d. Set middle to the floor of the average of left and right.
        // If the target is not found in the array, return -1.
    }
}