public class Solution
{
    public bool WordBreak(string s, IList<string> wordDict)
    {
        int n = s.Length;
        bool[] dp = new bool[n + 1];

        dp[0] = true;

        int maxLen = 0;
        foreach (string word in wordDict)
        {
            maxLen = Math.Max(maxLen, word.Length);
        }

        for (int i = 1; i <= n; i++)
        {
            for (int j = i - 1; j >= 0 && i - j <= maxLen; j--)
            {
                if (dp[j] && wordDict.Contains(s.Substring(j, i - j)))
                {
                    dp[i] = true;
                    break;
                }
            }
        }
        return dp[n];
    }
}