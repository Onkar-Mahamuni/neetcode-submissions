public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dict = new();

        foreach(string str in strs)
        {
            int[] count = new int[26];

            foreach(char c in str)
                count[c - 'a']++;

            string key = string.Join(",", count);

            if(!dict.ContainsKey(key))
                dict[key] = new List<string>();

            dict[key].Add(str);
        }

        return new List<List<string>>(dict.Values);
    }
}
