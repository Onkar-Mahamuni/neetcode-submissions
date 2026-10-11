public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();

        foreach (string str in strs)
            sb.Append($"{str.Length}#{str}");
        
        return sb.ToString();
    }

    public List<string> Decode(string s) 
    {
        List<string> opt = new List<string>();

        while(s.Length > 0)
        {
            var isp = s.IndexOf('#');

            int cnt = int.Parse(s.Substring(0, isp));
            string str = s.Substring(isp + 1, cnt);
            opt.Add(str);
            
            s = s.Substring(isp + 1 + cnt);
        }
        
        return opt;
    }
}
