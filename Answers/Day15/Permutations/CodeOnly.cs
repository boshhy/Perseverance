public class Solution
{
    public IList<IList<int>> Permute(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        List<int> currentCombination = new List<int>();

        Backtrack();

        return result;

        void Backtrack()
        {
            if (currentCombination.Count == nums.Length)
            {
                result.Add(new List<int>(currentCombination));
                return;
            }
            foreach (int num in nums)
            {
                if (currentCombination.Contains(num)) continue;
                currentCombination.Add(num);
                Backtrack();
                currentCombination.RemoveAt(currentCombination.Count - 1);
            }
        }
    }
}