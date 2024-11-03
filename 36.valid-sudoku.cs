/*
 * @lc app=leetcode id=36 lang=csharp
 *
 * [36] Valid Sudoku
 */

// @lc code=start
public class Solution
{

    private bool ContainsNoDuplicates(HashSet<char> numbers, char current)
    {
        return current == '.' || numbers.Add(current);
    }

    public bool IsValidSudoku(char[][] board)
    {

        // Check rows
        for (int i = 0; i < board.Length; i++)
        {
            var numbers = new HashSet<char>();
            for (int j = 0; j < board.Length; j++)
                if (!ContainsNoDuplicates(numbers, board[i][j]))
                    return false;

        }

        // Check columns
        for (int j = 0; j < board.Length; j++)
        {
            var numbers = new HashSet<char>();
            for (int i = 0; i < board.Length; i++)
                if (!ContainsNoDuplicates(numbers, board[i][j]))
                    return false;
        }

        // Check squares
        for (int row = 0; row < 9; row += 3)
        {
            for (int col = 0; col < 9; col += 3)
            {
                var numbers = new HashSet<char>();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                        if (!ContainsNoDuplicates(numbers, board[row + i][col + j]))
                            return false;
                }
            }
        }

        return true;
    }
}
// @lc code=end

