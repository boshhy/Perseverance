public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        List<IList<int>> result = new List<IList<int>>();
        Array.Sort(nums);

        int left;
        int right;
        int needed;
        int total;

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (nums[i] > 0)
            {
                break;
            }
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }

            left = i + 1;
            right = nums.Length - 1;

            needed = -nums[i];
            while (left < right)
            {
                total = nums[left] + nums[right];

                if (total < needed)
                {
                    left++;
                }
                else if (total > needed)
                {
                    right--;
                }
                else
                {
                    result.Add([nums[i], nums[left], nums[right]]);

                    left++;
                    right--;

                    while (nums[left] == nums[left - 1] && left < right)
                    {
                        left++;
                    }

                    while (nums[right] == nums[right + 1] && left < right)
                    {
                        right--;
                    }
                }
            }
        }

        return result;
    }
}