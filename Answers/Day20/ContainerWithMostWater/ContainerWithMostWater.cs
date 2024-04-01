public class Solution
{
    // Method to find the maximum area formed by two vertical lines and the x-axis, given an array of heights
    public int MaxArea(int[] height)
    {
        // Initialize variables to store the maximum area, left pointer, right pointer, and current area
        int result = 0; // Initialize maximum area
        int left = 0;   // Initialize left pointer to the start of the array
        int right = height.Length - 1; // Initialize right pointer to the end of the array
        int area = 0;   // Initialize current area

        // Loop until the left pointer is less than the right pointer
        while (left < right)
        {
            // Determine the height of the left and right pointers
            int leftHeight = height[left];
            int rightHeight = height[right];

            // Calculate the area formed by the two pointers and update the result with the maximum area
            area = (right - left) * Math.Min(leftHeight, rightHeight);
            result = Math.Max(result, area);

            // Move the pointer with the smaller height towards the other pointer
            if (leftHeight < rightHeight)
            {
                left++; // Move the left pointer to the right
            }
            else
            {
                right--; // Move the right pointer to the left
            }
        }
        // Return the maximum area found
        return result;
    }
}
