public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new();

        foreach(int num in nums)
            dict[num] = dict.GetValueOrDefault(num) + 1;
        
        List<int>[] cnt = new List<int>[nums.Length + 1];

        foreach (var (key, value) in dict)
        {
             if(cnt[value] == null) 
                cnt[value] = new List<int>();
             cnt[value].Add(key);
        }

        int[] opt = new int[k];
        int size = 0;
        for (int i = cnt.Length - 1 ; i > 0; i--)
        {
            if(cnt[i] == null) continue;

            foreach(int num in cnt[i])
            {
                opt[size] = num;
                size++;

                if(size == k) return opt;
            }
        }

        return opt;
    }
}
