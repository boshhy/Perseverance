// Overview
public class Solution
{
    public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        // This code implements a breadth-first search (BFS) algorithm to find the shortest transformation sequence from 
        // a starting word to an ending word. It first checks if the ending word exists in the provided word list and 
        // if the lengths of the starting and ending words are the same. Then, it initializes a HashSet for efficient 
        // word lookup and a Queue for BFS traversal. It iterates through each letter of each word in the queue, 
        // generating all possible one-letter transformations and checking if they exist in the word list. If the 
        // transformation matches the ending word, the current level of the BFS traversal is returned. Otherwise, valid 
        // transformations are enqueued for further exploration. If no transformation sequence is found, the function returns 0.
    }
}

// Comments
public class Solution
{
    public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        // Check if the end word is not in the word list or if the lengths of beginWord and endWord are different
        //     If any of the conditions are met, return 0

        // Create a HashSet to store the words for faster lookup
        //     Add each word from the word list to the hash set

        // Create a queue to perform BFS (Breadth-First Search)
        // Enqueue the starting word
        // Initialize the level to 1

        // Continue until the queue is empty
        //     Get the total number of words in the current level
        //     Increment the level for the next level

        //     Process all words at the current level
        //         Dequeue a word from the queue
        //         Convert the word to a character array

        //         Loop through each character of the current word
        //             Store the original character at index i

        //             Loop through all possible letters ('a' to 'z')
        //                     Skip if the letter is the same as the original character

        //                 Replace the character at index i with the current letter
        //                 Convert the character array back to a string

        //                 Check if the modified word exists in the word list
        //                     If the modified word is the end word, return the current level
        //                     Enqueue the modified word for further exploration
        //                     Remove the word from the hash set to avoid revisiting it}
        //             Restore the original character at index i for the next iteration
        //         Decrement the count of words at the current level
        // If no transformation sequence is found, return 0
    }
}

// Pseudocode
public class Solution
{
    public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        // if endWord is not in wordList or length of beginWord is not equal to length of endWord:
        //     return 0

        // hashSet = create a new empty HashSet
        // for each word in wordList:
        //     add word to hashSet

        // queue = create a new empty Queue
        // enqueue beginWord into queue
        // level = 1

        // while queue is not empty:
        //     totalWordCount = number of elements in queue
        //     increment level by 1

        //     while totalWordCount is greater than 0:
        //         currentWord = dequeue a word from queue
        //         currentWordChars = convert currentWord to character array

        //         for i from 0 to length of currentWord:
        //             originalChar = character at index i in currentWordChars

        //             for letter from 'a' to 'z':
        //                 if letter is equal to originalChar:
        //                     continue

        //                 currentWordChars[i] = letter
        //                 wordToTry = convert currentWordChars to string

        //                 if wordToTry is in hashSet:
        //                     if wordToTry is equal to endWord:
        //                         return level
        //                     enqueue wordToTry into queue
        //                     remove wordToTry from hashSet

        //             restore originalChar at index i in currentWordChars
        //         decrement totalWordCount by 1

        // return 0
    }
}
