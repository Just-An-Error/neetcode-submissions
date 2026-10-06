public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> map = new();
        foreach(int n in nums) {
            if(map.ContainsKey(n)) {
                map[n] ++;
            } else {
                map[n] = 1;
            }
        }
        var result = map.OrderByDescending(x => x.Value).Take(k).Select(k => k.Key).ToArray();
        return result;
    }
}
