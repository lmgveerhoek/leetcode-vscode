/*
 * @lc app=leetcode id=20 lang=csharp
 *
 * [20] Valid Parentheses
 */

// @lc code=start

public class Solution
{
    public bool IsValid(string s)
    {
        // Bases case
        if (s.Length == 1)
            return false;

        var bracketPairs = new Dictionary<char, char> {
            { '(', ')' },
            { '[', ']' },
            { '{', '}' }
        };

        // Create a Queue, to keep track of the brackets
        var parenthesesStack = new Stack<char>();

        foreach (var c in s)
        {
            // Add to stack if it's an opening bracket
            if (bracketPairs.ContainsKey(c))
                parenthesesStack.Push(c);
            // Check if there are brackets to close with or the stack is empty
            else if (parenthesesStack.Count == 0 || bracketPairs[parenthesesStack.Pop()] != c)
                return false;
        }

        return parenthesesStack.Count == 0;
    }
}
// @lc code=end

