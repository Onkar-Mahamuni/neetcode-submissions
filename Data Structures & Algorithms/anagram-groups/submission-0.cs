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

        int i = 0;
        List<List<string>> opt = new List<List<string>>();

        foreach(var (key, value) in dict)
        {
            opt.Add(new List<string>()); 

            foreach(string s in value)
                opt[i].Add(s);

            i++;
        }

        return opt;
    }
}
