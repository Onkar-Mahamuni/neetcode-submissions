public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> hs = new(nums);
        int res = 0;

        foreach (int num in hs)
        {
            if (!hs.Contains(num - 1))
            {
                int cnt = 1;
                int curr = num;

                while (hs.Contains(curr + 1))
                {
                    cnt++;
                    curr++;
                }

                res = Math.Max(res, cnt);
            }
        }

        return res;
    }
}