public class Solution
{
    // Method to check if the given word exists in the board
    public bool Exist(char[][] board, string word)
    {
        // Length of the word
        int wordLength = word.Length;
        // Number of rows in the board
        int rowLength = board.Length;
        // Number of columns in the board
        int columnLength = board[0].Length;

        // Loop through each cell in the board
        for (int row = 0; row < rowLength; row++)
        {
            for (int column = 0; column < columnLength; column++)
            {
                // Check if the current cell matches the first character of the word
                if (board[row][column] == word[0])
                {
                    // If it does, attempt to find the entire word starting from this cell
                    if (FindWord(row, column, 0))
                    {
                        // If the word is found, return true
                        return true;
                    }
                }
            }
        }

        // If the word is not found in any cell, return false
        return false;

        // Recursive method to find the word starting from a particular cell
        bool FindWord(int r, int c, int searchCount)
        {
            // If the current cell is out of bounds or does not match the next character in the word, return false
            if (r < 0 || r >= rowLength || c < 0 || c >= columnLength || board[r][c] != word[searchCount])
            {
                return false;
            }

            // Increment the search count to move to the next character in the word
            searchCount++;

            // If the entire word has been found, return true
            if (searchCount >= wordLength)
            {
                return true;
            }

            // Store the current character in the cell temporarily
            char removedChar = board[r][c];
            // Mark the current cell as visited
            board[r][c] = '_';

            // Recursively search in all four directions (up, down, left, right) for the next character of the word
            if (FindWord(r + 1, c, searchCount) ||
                FindWord(r, c + 1, searchCount) ||
                FindWord(r - 1, c, searchCount) ||
                FindWord(r, c - 1, searchCount))
            {
                // If the word is found in any of the directions, return true
                return true;
            }

            // If the word is not found after exploring all directions, backtrack by restoring the cell's original character
            board[r][c] = removedChar;
            return false;
        }
    }
}
