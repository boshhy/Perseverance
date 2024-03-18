public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> uniqueNumbers = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!uniqueNumbers.Add(nums[i]))
            {
                return true;
            }
        }
        return false;
    }
}