/*
 * @lc app=leetcode id=128 lang=csharp
 *
 * [128] Longest Consecutive Sequence
 */

// @lc code=start
using System.Globalization;

public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        var numbersSet = new HashSet<int>(nums);
        var longestSequenceLength = 0;

        foreach (var num in numbersSet)
        {
            if (!numbersSet.Contains(num - 1))
            {
                var currentSequenceLength = 1;

                var nextNumber = num + 1;
                while (numbersSet.Contains(nextNumber)) {
                    currentSequenceLength++;
                    nextNumber++;
                }

                longestSequenceLength = Math.Max(longestSequenceLength, currentSequenceLength);
            }

        }

        return longestSequenceLength;
    }
}
// @lc code=end

