class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        if (heights == null || heights.Length == 0)
        {
            return 0;
        }

        int maxArea = 0;

        Stack<int> stack = new Stack<int>();

        for (int index = 0; index <= heights.Length; index++)
        {
            int currentHeight = (index == heights.Length) ? 0 : heights[index];
            while (stack.Count > 0 && heights[stack.Peek()] > currentHeight)
            {
                int indexPopped = stack.Pop();
                int height = heights[indexPopped];
                int width = (stack.Count == 0) ? index : index - stack.Peek() - 1;

                maxArea = Math.Max(maxArea, height * width);
            }

            stack.Push(index);
        }
        return maxArea;
    }
}
