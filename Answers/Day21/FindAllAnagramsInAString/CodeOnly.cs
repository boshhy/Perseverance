public class Solution
{
    public IList<int> FindAnagrams(string s, string p)
    {
        int sLength = s.Length;
        int pLength = p.Length;
        IList<int> result = new List<int>();

        if (pLength > sLength)
        {
            return result;
        }

        int leftIndex = 0;
        int rightIndex = 0;
        int totalLettersMatched = 0;

        Dictionary<char, int> pCount = new Dictionary<char, int>();

        foreach (char letter in p)
        {
            if (!pCount.ContainsKey(letter))
            {
                pCount[letter] = 0;
            }
            pCount[letter]++;
        }

        while (rightIndex < sLength)
        {
            if (pCount.ContainsKey(s[rightIndex]) && pCount[s[rightIndex]] > 0)
            {
                pCount[s[rightIndex]]--;
                totalLettersMatched++;
                rightIndex++;
            }
            else if (pCount.ContainsKey(s[rightIndex]))
            {
                if (pCount.ContainsKey(s[leftIndex]))
                {
                    pCount[s[leftIndex]]++;
                    totalLettersMatched--;
                }
                leftIndex++;
            }
            else
            {
                while (leftIndex < rightIndex)
                {
                    if (pCount.ContainsKey(s[leftIndex]))
                    {
                        pCount[s[leftIndex]]++;
                        totalLettersMatched--;
                    }
                    leftIndex++;
                }
                leftIndex++;
                rightIndex++;
            }

            if (totalLettersMatched == pLength)
            {
                result.Add(leftIndex);
            }
        }
        return result;
    }
}