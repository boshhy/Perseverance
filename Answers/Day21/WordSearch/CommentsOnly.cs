// Overview
public class Solution
{
    public bool Exist(char[][] board, string word)
    {
        // This code is a part of a program designed to check whether a given word can be found within a 2D board of 
        // characters by traversing adjacent cells. It first initializes variables to store the lengths of the word 
        // and the board dimensions. Then, it iterates through each cell of the board, checking if the first character 
        // of the word matches the current cell. If it does, it calls a recursive function FindWord to search for the 
        // entire word starting from that cell. The FindWord function recursively explores all adjacent cells to find 
        // the consecutive characters of the word until the entire word is found or all possibilities are exhausted. 
        // If the word is found, it returns true; otherwise, it returns false.
    }
}

// Comments
public class Solution
{
    // Method to check if the given word exists in the board
    public bool Exist(char[][] board, string word)
    {
        // Length of the word
        // Number of rows in the board
        // Number of columns in the board

        // Using two for loops, Loop through each cell in the board
        //         Check if the current cell matches the first character of the word
        //             If it does, attempt to find the entire word starting from this cell
        //                 If the word is found, return true

        // If the word is not found in any cell, return false

        // Recursive method to find the word starting from a particular cell
        //     If the current cell is out of bounds or does not match the next character in the word, return false

        //     Increment the search count to move to the next character in the word

        //     If the entire word has been found, return true

        //     Store the current character in the cell temporarily
        //     Mark the current cell as visited

        //     Recursively search in all four directions (up, down, left, right) for the next character of the word
        //         If the word is found in any of the directions, return true

        //     If the word is not found after exploring all directions, backtrack by restoring the cell's original character
    }
}

// Pseudocode
public class Solution
{
    public bool Exist(char[][] board, string word)
    {
        // wordLength = length(word)
        // rowLength = length(board)
        // columnLength = length(board[0])

        // for row from 0 to rowLength - 1:
        //     for column from 0 to columnLength - 1:
        //         if board[row][column] == word[0]:
        //             if FindWord(row, column, 0):
        //                 return true

        // return false

        // function FindWord(r, c, searchCount):
        //     if r < 0 or r >= rowLength or c < 0 or c >= columnLength or board[r][c] != word[searchCount]:
        //         return false

        //     searchCount++

        //     if searchCount >= wordLength:
        //         return true

        //     removedChar = board[r][c]
        //     board[r][c] = '_'
        //     if FindWord(r + 1, c, searchCount) or FindWord(r, c + 1, searchCount) or FindWord(r - 1, c, searchCount) or FindWord(r, c - 1, searchCount):
        //         return true

        //     board[r][c] = removedChar
        //     return false
    }
}
