/*
 * @lc app=leetcode id=347 lang=csharp
 *
 * [347] Top K Frequent Elements
 */

// @lc code=start
public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // Create a dictionay to keep track of the frequency of the numbers
        var topKCount = new Dictionary<int, int>(); 

        // For each number, add it to the dictionay if it doesn't exist or add to the existing frequency
        foreach (var num in nums) {
            if (!topKCount.TryAdd(num, 1))
                topKCount[num]++;
        }

        // Sort the frequencies and take the top k numbers. 
        var sortedByFrequency = topKCount.OrderByDescending (kvp => kvp.Value);
        var topK = sortedByFrequency.Take(k).Select(kvp => kvp.Key).ToArray();

        return topK;
    }
}
// @lc code=end

