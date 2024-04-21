public class Solution
{
    public int Trap(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int maxLeft = height[left];
        int maxRight = height[right];
        int result = 0;

        while (left < right)
        {
            if (maxLeft <= maxRight)
            {
                left++;
                maxLeft = Math.Max(maxLeft, height[left]);
                result = result + (maxLeft - height[left]);
            }
            else
            {
                right--;
                maxRight = Math.Max(maxRight, height[right]);
                result = result + (maxRight - height[right]);
            }
        }
        return result;
    }
}
