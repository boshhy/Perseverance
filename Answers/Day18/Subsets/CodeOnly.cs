public class Solution
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        List<int> currentSubset = new List<int>();
        Backtrack(0);
        return result;

        void Backtrack(int index)
        {
            if (index >= nums.Length)
            {
                result.Add(new List<int>(currentSubset));
                return;
            }
            currentSubset.Add(nums[index]);
            Backtrack(index + 1);
            currentSubset.RemoveAt(currentSubset.Count - 1);
            Backtrack(index + 1);
        }
    }
}