public class Solution
{
    // Method to find the minimum window in string s which contains all characters of string t
    public string MinWindow(string s, string t)
    {
        // Dictionary to store the total count of each character in string t
        Dictionary<char, int> totalCharCountForT = new Dictionary<char, int>();
        // Dictionary to store the count of each character in the current window
        Dictionary<char, int> window = new Dictionary<char, int>();
        // Variable to store the minimum length of the window found so far
        int minimumLengthSoFar = int.MaxValue;
        // Variable to store the starting index of the minimum window found so far
        int leftLocation = -1;

        // Counting the occurrence of each character in string t and initializing the window dictionary
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

        // Variables to track the number of unique characters needed and the number of unique characters present in the window
        int need = totalCharCountForT.Count;
        int have = 0;

        // Pointers for the sliding window technique
        int left = 0;
        for (int right = 0; right < s.Length; right++)
        {
            char currentRightLetter = s[right];
            // If the current character is required in string t
            if (totalCharCountForT.ContainsKey(currentRightLetter))
            {
                // Increment the count of the current character in the window
                window[currentRightLetter]++;

                // If the count of the current character in the window matches its count in string t, increment the number of unique characters found
                if (window[currentRightLetter] == totalCharCountForT[currentRightLetter])
                {
                    have++;
                }

                // Adjust the window to find the minimum window satisfying the condition
                while (have == need)
                {
                    char currentLeftLetter = s[left];
                    if (window.ContainsKey(currentLeftLetter))
                    {
                        // Decrease the count of the leftmost character in the window
                        window[currentLeftLetter]--;

                        // If the count of the leftmost character becomes less than its count in string t, decrement the count of unique characters found
                        if (window[currentLeftLetter] < totalCharCountForT[currentLeftLetter])
                        {
                            have--;

                            // If the current window size is smaller than the minimum window found so far, update the minimum window size and its starting index
                            if (right - left + 1 < minimumLengthSoFar)
                            {
                                minimumLengthSoFar = right - left + 1;
                                leftLocation = left;
                            }
                        }
                    }
                    // Move the left pointer to shrink the window
                    left++;
                }
            }
        }

        // If no valid window is found, return an empty string
        if (leftLocation == -1)
        {
            return "";
        }

        // Return the substring of s containing the minimum window
        return s.Substring(leftLocation, minimumLengthSoFar);
    }
}
