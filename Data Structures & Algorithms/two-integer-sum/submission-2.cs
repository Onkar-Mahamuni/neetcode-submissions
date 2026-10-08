public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new();
        int[] opt = new int[2];

        for(int i = 0; i < nums.Length; i++)
            if(!dict.ContainsKey(nums[i]))
                dict.Add(nums[i], i);
            else
                dict[nums[i]] = i;
        
        for(int i = 0; i < nums.Length; i++)
            if(dict.ContainsKey(target - nums[i]) && dict[target - nums[i]] != i){
                opt[0] = i;
                opt[1] = dict[target - nums[i]];

                return opt;
            }
        return opt;
    }
}
