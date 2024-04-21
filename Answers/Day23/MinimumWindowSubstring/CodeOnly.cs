public class Solution
{
    public string MinWindow(string s, string t)
    {
        Dictionary<char, int> totalCharCountForT = new Dictionary<char, int>();
        Dictionary<char, int> window = new Dictionary<char, int>();
        int minimumLengthSoFar = int.MaxValue;
        int leftLocation = -1;

        foreach (char letter in t)
        {
            if (totalCharCountForT.ContainsKey(letter))
            {
                totalCharCountForT[letter]++;
            }
            else
            {
                totalCharCountForT[letter] = 1;
                window[letter] = 0;
            }
        }
        int need = totalCharCountForT.Count;
        int have = 0;

        int left = 0;
        for (int right = 0; right < s.Length; right++)
        {
            char currentRightLetter = s[right];
            if (totalCharCountForT.ContainsKey(currentRightLetter))
            {
                window[currentRightLetter]++;

                if (window[currentRightLetter] == totalCharCountForT[currentRightLetter])
                {
                    have++;
                }

                while (have == need)
                {
                    char currentLeftLetter = s[left];
                    if (window.ContainsKey(currentLeftLetter))
                    {
                        window[currentLeftLetter]--;
                        if (window[currentLeftLetter] < totalCharCountForT[currentLeftLetter])
                        {
                            have--;
                            if (right - left + 1 < minimumLengthSoFar)
                            {
                                minimumLengthSoFar = right - left + 1;
                                leftLocation = left;
                            }
                        }
                    }
                    left++;
                }
            }
        }

        if (leftLocation == -1)
        {
            return "";
        }

        return s.Substring(leftLocation, minimumLengthSoFar);
    }
}