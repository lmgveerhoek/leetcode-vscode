/*
 * @lc app=leetcode id=238 lang=csharp
 *
 * [238] Product of Array Except Self
 */

// @lc code=start
public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var leftProducts = new int[nums.Length];
        var rightProducts = new int [nums.Length];
        var result = new int[nums.Length];

        // Base cases
        leftProducts[0] = 1;
        rightProducts[nums.Length - 1] = 1;

        // Keep track of the product
        var product = 1;
        
        // Make a pass to build the left products
        for (int i = 1; i < nums.Length; i++) {
            product *= nums[i - 1];
            leftProducts[i] = product;
        }

        // Reset the product counter
        product = 1;

        // Make a pass to build the right products
        for (int i = nums.Length - 2; i >= 0; i--) {
            product *= nums[i + 1];
            rightProducts[i] = product;
        }

        // Make a pass to build the multipy those to get the result
        for (int i = 0; i < nums.Length; i++) {
           result[i] = leftProducts[i] * rightProducts[i];
        }

        return result;
    }
}
// @lc code=end

