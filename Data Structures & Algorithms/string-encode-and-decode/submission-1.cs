public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder opt = new StringBuilder();
        foreach(string str in strs)
        {
            char[] chars = str.ToCharArray();
            foreach(char ch in chars){
                opt.Append((int)ch);
                opt.Append(":");
            }

            opt.Append(",");
        }

        return opt.ToString();
    }

    public List<string> Decode(string s) {
        List<string> opt = new List<string>();

        char[] chrs = s.ToCharArray();

        StringBuilder optstr = new StringBuilder();
        StringBuilder optch = new StringBuilder();

        foreach(char ch in chrs)
        {
            if (ch != ':' && ch != ',')
                optch.Append(ch);
            else if (ch == ':')
            {
                optstr.Append((char)int.Parse(optch.ToString()));
                optch = new StringBuilder();
            }
            else
            {
                opt.Add(optstr.ToString());
                optstr = new StringBuilder();
            }
        }

        return opt;
   }
}
