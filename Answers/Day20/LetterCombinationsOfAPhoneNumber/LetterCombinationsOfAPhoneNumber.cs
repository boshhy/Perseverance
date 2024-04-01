public class Solution
{
    // Method to generate letter combinations based on input digits
    public IList<string> LetterCombinations(string digits)
    {
        // Initialize a list to store the generated combinations
        IList<string> result = new List<string>();

        // Dictionary mapping each digit to its corresponding letters
        Dictionary<char, string> digitToLetters = new Dictionary<char, string>
        {
            {'2', "abc"}, {'3', "def"},  {'4', "ghi"}, {'5', "jkl"},
            {'6', "mno"}, {'7', "pqrs"}, {'8', "tuv"}, {'9', "wxyz"}
        };

        // If the input digits are not empty
        if (digits != "")
        {
            // Call the recursive function to generate combinations starting from index 0
            GetCombinations(0, "");
        }

        // Return the list of generated combinations
        return result;

        // Recursive function to generate letter combinations
        void GetCombinations(int index, string currentStringCombination)
        {
            // If the index is equal to or exceeds the length of the input digits
            if (index >= digits.Length)
            {
                // Add the current combination to the result list
                result.Add(currentStringCombination);
                return;
            }

            // Iterate through each letter corresponding to the digit at the current index
            foreach (char letter in digitToLetters[digits[index]])
            {
                // Form a new combination by appending the current letter to the existing combination
                string newCombination = currentStringCombination + letter;
                // Recursively call the function with the next index and the new combination
                GetCombinations(index + 1, newCombination);
            }
        }
    }
}
