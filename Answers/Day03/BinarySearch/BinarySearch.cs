public class Solution
{
    public int Search(int[] nums, int target)
    {
        // Calculate the initial middle index of the array 
        int middle = nums.Length / 2;

        // Set the initial left pointer to the beginning of the array
        int left = 0;

        // Set the initial right pointer to the end of the array
        int right = nums.Length - 1;

        // Begin binary search loop while the left pointer is less than or equal to the right pointer
        while (left <= right)
        {
            // Check if the target value is found at the current middle index
            if (target == nums[middle])
            {
                return middle;
            }

            // If the target is less than the value at the current middle index,
            // adjust the right pointer to search the left subarray
            if (target < nums[middle])
            {
                right = middle - 1;
            }
            // Else the target is greater than the value at the current middle index,
            // adjust the left pointer to search the right subarray
            else
            {
                left = middle + 1;
            }

            // Recalculate the middle index to narrow the search range
            middle = (left + right) / 2;
        }

        // If the target is not found in the array, return -1
        return -1;
    }
}
