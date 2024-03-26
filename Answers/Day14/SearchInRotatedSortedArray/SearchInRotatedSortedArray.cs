public class Solution
{
    // Method for searching the target value in a sorted array using binary search.
    public int Search(int[] nums, int target)
    {
        // Initializing the leftmost index of the array.
        int left = 0;
        // Initializing the rightmost index of the array.
        int right = nums.Length - 1;
        // Variable to hold the index of the middle element.
        int mid;
        // Variables to hold the values of the elements at left, right, and mid indices.
        int leftNumber;
        int rightNumber;
        int midNumber;

        // Loop until the left index is less than or equal to the right index.
        while (left <= right)
        {
            // Calculate the index of the middle element.
            mid = (left + right) / 2;

            // Assign values of elements at left, right, and mid indices.
            leftNumber = nums[left];
            rightNumber = nums[right];
            midNumber = nums[mid];

            // If the target value is found at the middle index, return the index.
            if (midNumber == target)
            {
                return mid;
            }

            // Check if the left part of the array is sorted.
            if (leftNumber <= midNumber)
            {
                // If the target value is within the left sorted part, update the right index.
                if (leftNumber <= target && target < midNumber)
                {
                    right = mid - 1;
                }
                // If the target value is not within the left sorted part, update the left index.
                else
                {
                    left = mid + 1;
                }
            }
            // If the right part of the array is sorted.
            else
            {
                // If the target value is within the right sorted part, update the left index.
                if (midNumber < target && target <= rightNumber)
                {
                    left = mid + 1;
                }
                // If the target value is not within the right sorted part, update the right index.
                else
                {
                    right = mid - 1;
                }
            }
        }

        // If the target value is not found in the array, return -1.
        return -1;
    }
}
