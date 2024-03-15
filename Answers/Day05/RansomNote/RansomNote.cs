public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        // Dictionary to store character frequencies in the magazine.
        Dictionary<char, int> d = new Dictionary<char, int>();

        // Iterate through each character in the magazine.
        foreach (char letter in magazine)
        {
            // If the character already exists in the dictionary, increment its count.
            if (d.ContainsKey(letter))
            {
                d[letter]++;
            }
            // Otherwise, add the character to the dictionary with count 1.
            else
            {
                d[letter] = 1;
            }
        }

        // Iterate through each character in the ransom note.
        foreach (char letter in ransomNote)
        {
            // If the character does not exist in the magazine, return false.
            if (!d.ContainsKey(letter))
            {
                return false;
            }
            // If decrementing the count of the character in the dictionary makes it negative, return false.
            if (--d[letter] < 0)
            {
                return false;
            }
        }

        // If all characters in the ransom note can be constructed from the magazine, return true.
        return true;
    }
}
