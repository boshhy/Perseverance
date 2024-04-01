public class Solution
{
    public IList<string> LetterCombinations(string digits)
    {
        IList<string> result = new List<string>();

        Dictionary<char, string> digitToLetters = new Dictionary<char, string>
        {
            {'2', "abc"}, {'3', "def"},  {'4', "ghi"}, {'5', "jkl"},
            {'6', "mno"}, {'7', "pqrs"}, {'8', "tuv"}, {'9', "wxyz"}
        };

        if (digits != "")
        {
            GetCombinations(0, "");
        }

        return result;

        void GetCombinations(int index, string currentStringCombination)
        {
            if (index >= digits.Length)
            {
                result.Add(currentStringCombination);
                return;
            }

            foreach (char letter in digitToLetters[digits[index]])
            {
                string newCombination = currentStringCombination + letter;
                GetCombinations(index + 1, newCombination);
            }
        }
    }
}
