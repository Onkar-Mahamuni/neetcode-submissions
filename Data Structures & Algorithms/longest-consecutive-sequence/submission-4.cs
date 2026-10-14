public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> hs = new(nums);
        int res = 0;

        foreach (int num in hs)
        {
            if (!hs.Contains(num - 1))
            {
                int curr = 1;
                int c = num;

                while (hs.Contains(c + 1))
                {
                    curr++;
                    c++;
                }

                res = Math.Max(res, curr);
            }
        }

        return res;
    }
}