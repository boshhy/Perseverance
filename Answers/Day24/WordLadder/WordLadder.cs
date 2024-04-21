public class Solution
{
    public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        // Check if the end word is not in the word list or if the lengths of beginWord and endWord are different
        if (!wordList.Contains(endWord) || beginWord.Length != endWord.Length)
        {
            return 0; // If any of the conditions are met, return 0
        }

        // Create a HashSet to store the words for faster lookup
        HashSet<string> hashSet = new HashSet<string>();
        foreach (string word in wordList)
        {
            hashSet.Add(word); // Add each word from the word list to the hash set
        }

        // Create a queue to perform BFS (Breadth-First Search)
        Queue<string> queue = new Queue<string>();
        queue.Enqueue(beginWord); // Enqueue the starting word
        int level = 1; // Initialize the level to 1

        // Start BFS
        while (queue.Count > 0) // Continue until the queue is empty
        {
            int totalWordCount = queue.Count; // Get the total number of words in the current level
            level++; // Increment the level for the next level

            // Process all words at the current level
            while (totalWordCount > 0)
            {
                string currentWord = queue.Dequeue(); // Dequeue a word from the queue
                char[] currentWordChars = currentWord.ToArray(); // Convert the word to a character array

                // Loop through each character of the current word
                for (int i = 0; i < currentWord.Length; i++)
                {
                    char originalChar = currentWordChars[i]; // Store the original character at index i

                    // Loop through all possible letters ('a' to 'z')
                    for (char letter = 'a'; letter <= 'z'; letter++)
                    {
                        if (letter == originalChar)
                        {
                            continue; // Skip if the letter is the same as the original character
                        }

                        // Replace the character at index i with the current letter
                        currentWordChars[i] = letter;
                        string wordToTry = new string(currentWordChars); // Convert the character array back to a string

                        // Check if the modified word exists in the word list
                        if (hashSet.Contains(wordToTry))
                        {
                            // If the modified word is the end word, return the current level
                            if (endWord == wordToTry)
                            {
                                return level;
                            }
                            // Enqueue the modified word for further exploration
                            queue.Enqueue(wordToTry);
                            // Remove the word from the hash set to avoid revisiting it
                            hashSet.Remove(wordToTry);
                        }
                    }
                    // Restore the original character at index i for the next iteration
                    currentWordChars[i] = originalChar;
                }
                // Decrement the count of words at the current level
                totalWordCount--;
            }
        }
        // If no transformation sequence is found, return 0
        return 0;
    }
}
