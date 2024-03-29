public class Solution
{
    public bool CanPartition(int[] nums)
    {
        int totalSum = nums.Sum();

        if (totalSum % 2 != 0)
        {
            return false;
        }

        int targetAmount = totalSum / 2;

        bool[] isSumAchievable = new bool[targetAmount + 1];
        isSumAchievable[0] = true;

        foreach (int retreatAmount in nums)
        {
            for (int currentAmount = targetAmount; currentAmount >= retreatAmount; currentAmount--)
            {
                isSumAchievable[currentAmount] = isSumAchievable[currentAmount] || isSumAchievable[currentAmount - retreatAmount];

                if (isSumAchievable[targetAmount])
                {
                    return true;
                }
            }
        }

        return false;
    }
}
