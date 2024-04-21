class Solution
{
    // Method to find the largest rectangle area in a histogram represented by the heights array.
    public int LargestRectangleArea(int[] heights)
    {
        // Check if the heights array is null or empty.
        if (heights == null || heights.Length == 0)
        {
            // If so, return 0 as there's no area to calculate.
            return 0;
        }

        // Variable to store the maximum area found so far.
        int maxArea = 0;

        // Stack to store indices of heights array.
        Stack<int> stack = new Stack<int>();

        // Iterate through each index of the heights array and an additional iteration for index == heights.Length.
        for (int index = 0; index <= heights.Length; index++)
        {
            // Determine the current height. If index exceeds the array length, set currentHeight to 0.
            int currentHeight = (index == heights.Length) ? 0 : heights[index];

            // Pop elements from the stack until the current height is greater than or equal to the height at the top of the stack.
            while (stack.Count > 0 && heights[stack.Peek()] > currentHeight)
            {
                // Pop the index of the height from the stack.
                int indexPopped = stack.Pop();

                // Get the height of the popped element.
                int height = heights[indexPopped];

                // Calculate the width of the rectangle.
                int width = (stack.Count == 0) ? index : index - stack.Peek() - 1;

                // Update maxArea with the maximum of its current value and the area of the rectangle formed by the popped element.
                maxArea = Math.Max(maxArea, height * width);
            }

            // Push the current index onto the stack.
            stack.Push(index);
        }

        // Return the maximum area found.
        return maxArea;
    }
}
