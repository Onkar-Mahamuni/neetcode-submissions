public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> dict = new();

        foreach(int num in nums)
            if(dict.ContainsKey(num))
                return true;
            else
                dict.Add(num, 1);
        
        return false;
    }
}