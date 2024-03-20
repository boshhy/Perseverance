// Overview
public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        // The provided code aims to find all unique triplets in an array 'nums' that sum up to zero. 
        // It initializes an empty list 'result' to store the triplets. It then sorts the 'nums' array. Using nums[i] as 
        // the first number then using two pointers, 'left' and 'right', the code iterates through 'nums', checking for triplets 
        // that meet the sum criteria. It ensures uniqueness by skipping duplicates. The algorithm terminates 
        // when all possible triplets have been checked, returning the 'result' list containing all found triplets.
    }
}

// Comments
public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        // Creates a list to store lists of integers, which will contain the result

        // Sorts the input array of integers in ascending order

        // Declares 4 variables to keep track of indices and values
        // left and right pointers, 'needed' amount to equal 0, total from sum of left and right

        // Iterates through the sorted array to find triplets that sum up to zero
        //     If the current number is greater than 0, there won't be any triplets that sum to zero, so break the loop
        //     Skips to the next iteration if the current number is equal to the previous number, to avoid duplicates

        //     Initializes pointers for two numbers to search for the third number that sums up to zero

        //     Calculates the value needed to make the current number and the two numbers pointed by left and right to sum up to zero

        //     Loops until the left pointer crosses the right pointer
        //         Calculates the total sum of the numbers pointed by left and right pointers

        //         If the total sum is less than the needed value, move the left pointer to the right to increase the sum
        //         If the total sum is greater than the needed value, move the right pointer to the left to decrease the sum
        //         If the total sum is equal to the needed value, a triplet is found
        //             Adds the triplet [nums[i], nums[left], nums[right]] to the result list
        //             Moves both pointers inward and skips duplicate numbers
        //             Skips over duplicate numbers to avoid duplicate triplets
        //             Skips over duplicate numbers to avoid duplicate triplets

        // Returns the list of triplets that sum up to zero
    }
}

// Pseudocode
public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        // result = Empty List of Lists
        // Sort nums

        // For i = 0 to length of nums - 2
        //     If nums[i] > 0
        //         Break loop
        //     If i > 0 and nums[i] == nums[i - 1]
        //         Continue to next iteration

        //     left = i + 1
        //     right = Length of nums - 1

        //     needed = -nums[i]
        //     While left < right
        //         total = nums[left] + nums[right]

        //         If total < needed
        //             Increment left
        //         Else If total > needed
        //             Decrement right
        //         Else
        //             Add [nums[i], nums[left], nums[right]] to result

        //             Increment left
        //             Decrement right

        //             While nums[left] == nums[left - 1] and left < right
        //                 Increment left

        //             While nums[right] == nums[right + 1] and left < right
        //                 Decrement right

        // Return result
    }
}