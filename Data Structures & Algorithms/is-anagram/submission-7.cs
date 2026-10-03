public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) {
            return false;
        }
        Dictionary<char, int> map = new();
        foreach(char c in s) {
            if(map.TryGetValue(c, out int valore)) {
                map[c] = valore + 1;
            } else {
                map[c] = 1;
            }
        }
        foreach(char c in t) {
            if(map.TryGetValue(c, out int valore)) {
                if(valore != 0) {
                    map[c] = valore - 1;
                } else {
                    return false;
                }
            } else {
                return false;
            }
        }
        return true;
    }
}
