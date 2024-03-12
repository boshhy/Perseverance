public class Solution
{
    public int Search(int[] nums, int target)
    {
        int middle = nums.Length / 2;

        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            if (target == nums[middle])
            {
                return middle;
            }

            if (target < nums[middle])
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
            middle = (left + right) / 2;
        }
        return -1;
    }
}