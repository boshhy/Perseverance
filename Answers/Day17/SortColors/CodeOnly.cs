public class Solution
{
    public void SortColors(int[] nums)
    {
        int left = 0;
        int right = nums.Length - 1;
        int current = 0;

        while (current <= right)
        {
            if (nums[current] == 2)
            {
                Swap(current, right);
                right--;
            }
            else if (nums[current] == 0)
            {
                Swap(left, current);
                left++;
                current++;
            }
            else
            {
                current++;
            }
        }

        void Swap(int x, int y)
        {
            (nums[x], nums[y]) = (nums[y], nums[x]);
        }
    }
}