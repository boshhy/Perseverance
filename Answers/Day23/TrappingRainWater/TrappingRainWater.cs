public class Solution
{
    public int Trap(int[] height)
    {
        // Initialize pointers for the leftmost and rightmost positions of the array.
        int left = 0;
        int right = height.Length - 1;

        // Initialize variables to keep track of the maximum height encountered from the left and right sides.
        int maxLeft = height[left];
        int maxRight = height[right];

        // Initialize a variable to store the result, which represents the total trapped water.
        int result = 0;

        // Loop until the pointers meet each other.
        while (left < right)
        {
            // If the height of the left side is less than or equal to the height of the right side.
            if (maxLeft <= maxRight)
            {
                // Move the left pointer to the right.
                left++;

                // Update the maxLeft if the height of the current position is greater.
                maxLeft = Math.Max(maxLeft, height[left]);

                // Calculate the amount of water that can be trapped at the current position and add it to the result.
                result = result + (maxLeft - height[left]);
            }
            else // If the height of the right side is greater.
            {
                // Move the right pointer to the left.
                right--;

                // Update the maxRight if the height of the current position is greater.
                maxRight = Math.Max(maxRight, height[right]);

                // Calculate the amount of water that can be trapped at the current position and add it to the result.
                result = result + (maxRight - height[right]);
            }
        }
        // Return the total trapped water.
        return result;
    }
}
