public class Solution
{
    public int MaxArea(int[] height)
    {
        int result = 0;
        int left = 0;
        int right = height.Length - 1;
        int area = 0;

        while (left < right)
        {
            int leftHeight = height[left];
            int rightHeight = height[right];

            area = (right - left) * Math.Min(leftHeight, rightHeight);
            result = Math.Max(result, area);

            if (leftHeight < rightHeight)
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return result;
    }
}