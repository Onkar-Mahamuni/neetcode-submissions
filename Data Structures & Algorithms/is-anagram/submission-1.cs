public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        int[] count1 = new int[255];
        int[] count2 = new int[255];

        for(int i = 0; i < s.Length; i++)
            count1[(int)s[i]]++;
        
        for(int i = 0; i < t.Length; i++)
            count2[(int)t[i]]++;
        
        for(int i = 0; i < count1.Length; i++)
            if(count1[i] != count2[i])
                return false;
        
        return true;
    }
}
