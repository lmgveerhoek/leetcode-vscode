/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Create a dictionary to store the indices of each number
        var numDictionary = new Dictionary<int, int>(); 

        // For each number in the array, add the index to the dictionary
        for (int i = 0; i < nums.Length; i++) {
            if (!numDictionary.ContainsKey(nums[i]))
                numDictionary[nums[i]] = i; 
            
            // Calculate the remainder and check if it is contained within the dictionary
            var remainder = target - nums[i]; 
            if (numDictionary.ContainsKey(remainder)) {
                var index = numDictionary[remainder];
                // If the index is not the same, then it is a valid pair
                if (i != index)
                    return [i, index];
            }
        }
        return [];
    }
}
// @lc code=end

