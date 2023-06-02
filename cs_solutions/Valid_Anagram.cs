public class Solution {
    public bool IsAnagram(string s, string t) {
        List<char> chars1 = new List<char>();
        chars1.AddRange(s);
        chars1.Sort();
        List<char> chars2 = new List<char>();
        chars2.AddRange(t);
        chars2.Sort();
        return chars1.SequenceEqual(chars2);
    }
}