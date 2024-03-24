public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] result = new int[nums.Length];
        result[0] = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            result[i] = nums[i - 1] * result[i - 1];
        }

        int container = 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            result[i] = container * result[i];
            container *= nums[i];
        }

        return result;
    }
}