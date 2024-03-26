// Overview
public class Solution
{
    public int Search(int[] nums, int target)
    {
        // This code implements a binary search algorithm to find a target value within a rotated sorted array. 
        // It initializes two pointers, 'left' and 'right', at the start and end of the array, respectively. 
        // It then iteratively divides the search space in half and adjusts the pointers based on the comparison 
        // of the target value with the elements at the midpoint and the ends of the current search range. 
        // The algorithm returns the index of the target value if found, otherwise -1 is returned.
    }
}

// Comments
public class Solution
{
    // Method for searching the target value in a sorted array using binary search.
    public int Search(int[] nums, int target)
    {
        // Initializing the leftmost index of the array.
        // Initializing the rightmost index of the array.
        // Variable to hold the index of the middle element.
        // Variables to hold the values of the elements at left, right, and mid indices.

        // Loop until the left index is less than or equal to the right index.
        //     Calculate the index of the middle element.

        //     Assign values of elements at left, right, and mid indices.

        //     If the target value is found at the middle index, return the index.

        //     Check if the left part of the array is sorted.
        //         If the target value is within the left sorted part, update the right index.
        //         If the target value is not within the left sorted part, update the left index.
        //     If the right part of the array is sorted.
        //         If the target value is within the right sorted part, update the left index.
        //         If the target value is not within the right sorted part, update the right index.

        // If the target value is not found in the array, return -1.
    }
}

// Pseudocode
public class Solution
{
    public int Search(int[] nums, int target)
    {
        // left = 0
        // right = nums.length - 1
        // while left <= right:
        //     mid = (left + right) / 2
        //     leftNumber = nums[left]
        //     rightNumber = nums[right]
        //     midNumber = nums[mid]
        //     if midNumber == target:
        //         return mid
        //     if leftNumber <= midNumber:
        //         if leftNumber <= target && target < midNumber:
        //             right = mid - 1
        //         else:
        //             left = mid + 1
        //     else:
        //         if midNumber < target && target <= rightNumber:
        //             left = mid + 1
        //         else:
        //             right = mid - 1
        // return -1
    }
}