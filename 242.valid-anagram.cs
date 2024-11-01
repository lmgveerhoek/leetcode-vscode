/*
 * @lc app=leetcode id=242 lang=csharp
 *
 * [242] Valid Anagram
 */

// @lc code=start
public class Solution {
    public bool IsAnagram(string s, string t) {
        // Split the strings in characters
        char[] charsS = s.ToCharArray(); 
        char[] charsT = t.ToCharArray(); 

        // Create Dictionaries to keep track of the characters in both strings
        var charsDictS = new Dictionary<char, int>();
        var charsDictT = new Dictionary<char, int>();


        // Add the chars of both strings to the Dictionaries 
        foreach (char c in charsS) 
            if (!charsDictS.TryGetValue(c, out int value))
                charsDictS.Add(c, 1);
            else 
                charsDictS[c] = ++value;
        
        foreach (char c in charsT) 
            if (!charsDictT.TryGetValue(c, out int value))
                charsDictT.Add(c, 1);
            else 
                charsDictT[c] = ++value;
    
        // Compare the Dictionaries's to determine if the strings have the same length
        if (charsDictS.Count != charsDictT.Count)
            return false;

        // Check if the strings have the same character count
        foreach (var kvp in charsDictS)
        {
            if (!charsDictT.TryGetValue(kvp.Key, out int value) || value != kvp.Value)
                return false;
        }

        return true;
    }
}
// @lc code=end

