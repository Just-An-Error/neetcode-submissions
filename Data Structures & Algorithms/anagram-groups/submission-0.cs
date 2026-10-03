public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> mappa = new();
        var orderWord = "";
        foreach(string s in strs) {
            orderWord = string.Concat(s.OrderBy(c => c));
            if(mappa.TryGetValue(orderWord, out List<string> wordsResult)){
                wordsResult.Add(s);
            } else {
                mappa[orderWord] = [s];
            }
        }
        return mappa.Values.ToList();
    }
}
