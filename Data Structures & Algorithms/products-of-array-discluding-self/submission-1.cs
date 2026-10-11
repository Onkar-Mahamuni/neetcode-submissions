public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        if(nums.Length <= 1) return nums;
        if(nums.Length == 2) return new int [] { nums[1], nums[0] };

        int[] prefixProd = new int[nums.Length];
        int[] suffixProd = new int[nums.Length];
        int[] res = new int[nums.Length];

        prefixProd[0] = nums[0];
        suffixProd[nums.Length - 1] = nums[nums.Length - 1];

        for (int i = 1 ; i < nums.Length; i++)
            prefixProd[i] = prefixProd[i-1] * nums[i];

        for (int i = nums.Length - 2; i >= 0; i--)
            suffixProd[i] = suffixProd[i+1] * nums[i];
        
        res[0] = suffixProd[1];
        res[nums.Length - 1] = prefixProd[nums.Length - 2];
        for (int i = 1; i < nums.Length - 1; i++)
            res[i] = prefixProd[Math.Max(i - 1, 0)] * suffixProd[Math.Min(i + 1, nums.Length - 1)];
        
        return res;
    }
}
