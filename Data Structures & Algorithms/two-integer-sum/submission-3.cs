public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new();
        
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            
            // If the complement is already in the dictionary, we found our pair!
            if (dict.TryGetValue(complement, out int complementIndex)) {
                return new int[] { complementIndex, i };
            }
            
            // Otherwise, add/update the current number and its index in the dictionary
            dict[nums[i]] = i;
        }
        
        return Array.Empty<int>(); // Fallback (LeetCode guarantees exactly one solution)
    }
}

