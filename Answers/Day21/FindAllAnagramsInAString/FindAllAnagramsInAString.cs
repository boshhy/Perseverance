public class Solution
{
    // Method to find all anagrams of string p in string s
    public IList<int> FindAnagrams(string s, string p)
    {
        // Store the lengths of strings s and p
        int sLength = s.Length;
        int pLength = p.Length;

        // Initialize a list to store the indices of found anagrams
        IList<int> result = new List<int>();

        // If the length of p is greater than the length of s, return empty result
        if (pLength > sLength)
        {
            return result;
        }

        // Initialize indices for sliding window technique
        int leftIndex = 0;
        int rightIndex = 0;

        // Counter to keep track of the total letters matched
        int totalLettersMatched = 0;

        // Dictionary to count the occurrences of each letter in string p
        Dictionary<char, int> pCount = new Dictionary<char, int>();

        // Populate the dictionary with the counts of each letter in string p
        foreach (char letter in p)
        {
            if (!pCount.ContainsKey(letter))
            {
                pCount[letter] = 0;
            }
            pCount[letter]++;
        }

        // Sliding window technique to iterate through string s
        while (rightIndex < sLength)
        {
            // If the current character is found in string p and its count is greater than 0
            if (pCount.ContainsKey(s[rightIndex]) && pCount[s[rightIndex]] > 0)
            {
                // Decrement the count for the current character in p
                pCount[s[rightIndex]]--;

                // Increment total letters matched
                totalLettersMatched++;

                // Move the right index of the window
                rightIndex++;
            }
            // If the current character is found in p but its count is 0
            else if (pCount.ContainsKey(s[rightIndex]))
            {
                // Increment the count for the character at the left index in p
                pCount[s[leftIndex]]++;

                // Decrement total letters matched
                totalLettersMatched--;

                // Move the left index of the window
                leftIndex++;
            }
            // If the current character is not found in p
            else
            {
                // Move both left and right indices until they're equal
                while (leftIndex < rightIndex)
                {
                    // Increment the count for the character at the left index in p
                    pCount[s[leftIndex]]++;

                    // Decrement total letters matched
                    totalLettersMatched--;

                    // Move the left index
                    leftIndex++;
                }
                // Move both left and right indices to continue the iteration
                leftIndex++;
                rightIndex++;
            }

            // If all letters in p are matched, add the left index of the window to result
            if (totalLettersMatched == pLength)
            {
                result.Add(leftIndex);
            }
        }

        // Return the list of indices of found anagrams
        return result;
    }
}
