public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        int[] count = new int[255];

        for(int i = 0; i < s.Length; i++)
        {
            count[(int)s[i]]++;
            count[(int)t[i]]--;
        }
        
        foreach (int cnt in count)
            if(cnt != 0) return false;
        
        return true;
    }
}
