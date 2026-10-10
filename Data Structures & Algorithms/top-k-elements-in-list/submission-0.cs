public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new();

        foreach(int num in nums)
            dict[num] = dict.GetValueOrDefault(num) + 1;
        
        return dict.OrderByDescending(kvp => kvp.Value)
                    .Take(k).Select(kvp => kvp.Key)
                    .ToArray();
    }
}
