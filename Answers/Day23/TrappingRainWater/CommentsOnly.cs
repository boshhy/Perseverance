// Overview
public class Solution
{
    public int Trap(int[] height)
    {
        // The provided code calculates the amount of water that can be trapped between the bars represented by the 
        // heights array. It initializes two pointers, left and right, which start from the leftmost and rightmost 
        // positions of the array, respectively. Then, it iterates through the array while the left pointer is 
        // less than the right pointer. During each iteration, it compares the maximum heights from the 
        // left and right sides (maxLeft and maxRight). It incrementally moves the pointers towards each other, 
        // updating the maximum heights encountered and calculating the trapped water based on the difference between 
        // the current maximum height and the actual height of the bars. 
        // Finally, it returns the total trapped water.
    }
}

// Comments
public class Solution
{
    public int Trap(int[] height)
    {
        // Initialize pointers for the leftmost and rightmost positions of the array.

        // Initialize variables to keep track of the maximum height encountered from the left and right sides.

        // Initialize a variable to store the result, which represents the total trapped water.

        // Loop until the pointers meet each other.
        //     If the height of the left side is less than or equal to the height of the right side.
        //         Move the left pointer to the right.

        //         Update the maxLeft if the height of the current position is greater.

        //         Calculate the amount of water that can be trapped at the current position and add it to the result.
        //     If the height of the right side is greater.
        //         Move the right pointer to the left.

        //         Update the maxRight if the height of the current position is greater.

        //         Calculate the amount of water that can be trapped at the current position and add it to the result.
        // Return the total trapped water.
    }
}


// Pseudocode
public class Solution
{
    public int Trap(int[] height)
    {
        // left = 0
        // right = length(height) - 1
        // maxLeft = height[left]
        // maxRight = height[right]
        // result = 0

        // while left < right:
        //     if maxLeft <= maxRight:
        //         left++
        //         maxLeft = max(maxLeft, height[left])
        //         result = result + (maxLeft - height[left])
        //     else:
        //         right--
        //         maxRight = max(maxRight, height[right])
        //         result = result + (maxRight - height[right])

        // return result
    }
}
