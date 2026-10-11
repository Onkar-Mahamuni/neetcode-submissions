public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int product = 1;
        int zeroCount = 0;
        int[] opt = new int[nums.Length];

        foreach (int num in nums)
            if (num != 0) 
                product *= num;
            else
            {
                zeroCount++;
                if (zeroCount > 1) return opt;
            }
        

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0 && zeroCount == 1) opt[i] = product;
            else if (zeroCount == 1) opt[i] = 0;
            else opt[i] = product / nums[i];
        }

        return opt;
    }
}
