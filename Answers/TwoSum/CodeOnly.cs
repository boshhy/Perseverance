public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> pastNumbers = new Dictionary<int, int>();
        int difference;

        for (int i = 0; i < nums.Length; i++)
        {
            difference = target - nums[i];

            if (pastNumbers.ContainsKey(difference))
            {
                return new int[] { i, pastNumbers[difference] };
            }

            pastNumbers[nums[i]] = i;
        }

        return new int[0];
    }
}
