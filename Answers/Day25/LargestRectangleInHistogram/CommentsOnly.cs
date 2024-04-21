// Overview
class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        // This code calculates the largest rectangular area in a histogram represented by the heights array. It first checks if 
        // the array is null or empty and returns 0 if so. It then iterates through each index of the array, simulating the process 
        // of finding the largest rectangle. It uses a stack to keep track of the indices of the heights, ensuring a monotonically 
        // increasing stack. When encountering a height smaller than the previous one, it calculates the area of the rectangle formed 
        // by the previous height and updates the maximum area accordingly. Finally, it returns the maximum area found.
    }
}

// Comments
class Solution
{
    // Method to find the largest rectangle area in a histogram represented by the heights array.
    public int LargestRectangleArea(int[] heights)
    {
        // Check if the heights array is null or empty.
        //     If so, return 0 as there's no area to calculate.

        // Variable to store the maximum area found so far.

        // Stack to store indices of heights array.

        // Iterate through each index of the heights array and an additional iteration for index == heights.Length.
        //     Determine the current height. If index exceeds the array length, set currentHeight to 0.

        //     Pop elements from the stack until the current height is greater than or equal to the height at the top of the stack.
        //         Pop the index of the height from the stack.

        //         Get the height of the popped element.

        //         Calculate the width of the rectangle.

        //         Update maxArea with the maximum of its current value and the area of the rectangle formed by the popped element.

        //     Push the current index onto the stack.

        // Return the maximum area found.
    }
}

// Pseudocode
class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        // if heights is null or heights is empty:
        //     return 0

        // maxArea = 0
        // stack = empty Stack

        // for index from 0 to length of heights inclusive:
        //     if index is equal to length of heights:
        //         currentHeight = 0
        //     else:
        //         currentHeight = heights[index]

        //     while stack is not empty and heights[top of stack] > currentHeight:
        //         indexPopped = pop top element from stack
        //         height = heights[indexPopped]
        //         if stack is empty:
        //             width = index
        //         else:
        //             width = index - top element of stack - 1

        //         maxArea = maximum of maxArea and height * width

        //     push index onto stack

        // return maxArea
    }
}
