using System.Diagnostics.Tracing;

public class Solution
{
    public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        if (!wordList.Contains(endWord) || beginWord.Length != endWord.Length)
        {
            return 0;
        }

        HashSet<string> hashSet = new HashSet<string>();
        foreach (string word in wordList)
        {
            hashSet.Add(word);
        }

        Queue<string> queue = new Queue<string>();
        queue.Enqueue(beginWord);
        int level = 1;

        while (queue.Count > 0)
        {
            int totalWordCount = queue.Count;
            level++;
            while (totalWordCount > 0)
            {
                string currentWord = queue.Dequeue();
                char[] currentWordChars = currentWord.ToArray();

                for (int i = 0; i < currentWord.Length; i++)
                {
                    char originalChar = currentWordChars[i];
                    for (char letter = 'a'; letter <= 'z'; letter++)
                    {
                        if (letter == originalChar)
                        {
                            continue;
                        }

                        currentWordChars[i] = letter;
                        string wordToTry = new string(currentWordChars);

                        if (hashSet.Contains(wordToTry))
                        {
                            if (endWord == wordToTry)
                            {
                                return level;
                            }
                            queue.Enqueue(wordToTry);
                            hashSet.Remove(wordToTry);

                        }


                    }
                    currentWordChars[i] = originalChar;
                }


                totalWordCount--;
            }
        }


        return 0;
    }
}