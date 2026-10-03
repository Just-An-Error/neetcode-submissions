public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numberSaved = new();
        var indexNumber = 0;
        foreach(int n in nums) {
            var targetNumber = target - n;
            if(numberSaved.TryGetValue(targetNumber, out int index)) {
                return [index, indexNumber];
            } else {
                numberSaved.Add(n, indexNumber);
            }
            indexNumber ++;
        }
        return [];
    }
}
