public class Solution
{
    public int Search(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        int mid;
        int leftNumber;
        int rightNumber;
        int midNumber;

        while (left <= right)
        {
            mid = (left + right) / 2;

            leftNumber = nums[left];
            rightNumber = nums[right];
            midNumber = nums[mid];

            if (midNumber == target)
            {
                return mid;
            }

            if (leftNumber <= midNumber)
            {
                if (leftNumber <= target && target < midNumber)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            else
            {
                if (midNumber < target && target <= rightNumber)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
        }

        return -1;
    }
}