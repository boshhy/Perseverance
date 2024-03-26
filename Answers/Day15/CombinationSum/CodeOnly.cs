class Solution
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        IList<IList<int>> result = new List<IList<int>>();
        List<int> currentCombination = new List<int>();

        GetUniqueCombinations(target, 0);

        return result;

        void GetUniqueCombinations(int target, int start)
        {
            if (target <= 0)
            {
                if (target == 0)
                {
                    result.Add(new List<int>(currentCombination));
                }
                return;
            }

            for (int i = start; i < candidates.Length; i++)
            {
                currentCombination.Add(candidates[i]);
                GetUniqueCombinations(target - candidates[i], i);
                currentCombination.RemoveAt(currentCombination.Count - 1);
            }
        }
    }
}