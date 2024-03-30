public class Solution
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        List<int> currentSubset = new List<int>();
        Backtrack(0);
        return result;

        void Backtrack(int start)
        {
            result.Add(new List<int>(currentSubset));

            for (int i = start; i < nums.Length; i++)
            {
                currentSubset.Add(nums[i]);
                Backtrack(i + 1);
                currentSubset.RemoveAt(currentSubset.Count - 1);
            }
        }
    }
}