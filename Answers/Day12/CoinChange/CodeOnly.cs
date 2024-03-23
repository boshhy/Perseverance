public class Solution
{
    public int CoinChange(int[] coins, int amount)
    {
        int[] total = new int[amount + 1];

        for (int i = 0; i < total.Length; i++)
        {
            total[i] = amount + 1;
        }

        total[0] = 0;

        for (int currentAmount = 1; currentAmount < total.Length; currentAmount++)
        {
            foreach (int coin in coins)
            {
                if (currentAmount - coin >= 0)
                {
                    total[currentAmount] = Math.Min(total[currentAmount], total[currentAmount - coin] + 1);
                }
            }
        }

        return (total[amount] == amount + 1) ? -1 : total[amount];
    }
}