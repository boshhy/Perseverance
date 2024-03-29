public class Solution
{
    // Method to check if a string can be segmented into words from a given word dictionary
    public bool WordBreak(string s, IList<string> wordDict)
    {
        // Length of the input string
        int n = s.Length;

        // Create a boolean array of length n+1 to store results of subproblems
        bool[] dp = new bool[n + 1];

        // Base case: an empty string is always breakable
        dp[0] = true;

        // Find the maximum length of words in the dictionary
        int maxLen = 0;
        foreach (string word in wordDict)
        {
            // Update maxLen to the maximum length of words in the dictionary
            maxLen = Math.Max(maxLen, word.Length);
        }

        // Loop through each character in the input string
        for (int i = 1; i <= n; i++)
        {
            // Loop through possible word lengths before the current position i
            for (int j = i - 1; j >= 0 && i - j <= maxLen; j--)
            {
                // If the substring from j to i is in the dictionary and dp[j] is true (substring ending at j is breakable)
                if (dp[j] && wordDict.Contains(s.Substring(j, i - j)))
                {
                    // Set dp[i] to true, indicating that substring ending at i is breakable
                    dp[i] = true;
                    // Break the inner loop, as we have found a solution for dp[i]
                    break;
                }
            }
        }
        // Return the result for the entire string
        return dp[n];
    }
}
