public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dict = new();

        foreach (string str in strs)
        {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);

            string key = new string(chars);

            if(dict.ContainsKey(key))
                dict[key].Add(str);
            else
                dict.Add(key, new List<string>() { str });
        }

        return new List<List<string>>(dict.Values);
    }
}
