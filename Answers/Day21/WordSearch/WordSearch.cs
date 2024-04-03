public class Solution
{
    public bool Exist(char[][] board, string word)
    {
        int wordLength = word.Length;
        int rowLength = board.Length;
        int columnLength = board[0].Length;

        for (int row = 0; row < rowLength; row++)
        {
            for (int column = 0; column < columnLength; column++)
            {
                if (board[row][column] == word[0])
                {
                    if (FindWord(row, column, 0))
                    {
                        return true;
                    }
                }
            }
        }

        return false;

        bool FindWord(int r, int c, int searchCount)
        {
            if (r < 0 || r >= rowLength || c < 0 || c >= columnLength || board[r][c] != word[searchCount])
            {
                return false;
            }

            searchCount++;

            if (searchCount >= wordLength)
            {
                return true;
            }

            char removedChar = board[r][c];
            board[r][c] = '_';
            if (FindWord(r + 1, c, searchCount) ||
            FindWord(r, c + 1, searchCount) ||
            FindWord(r - 1, c, searchCount) ||
            FindWord(r, c - 1, searchCount))
            {
                return true;
            }

            board[r][c] = removedChar;
            return false;
        }
    }
}
