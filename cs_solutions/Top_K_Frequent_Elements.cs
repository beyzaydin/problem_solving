public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
         var result = new List<int>();
    var countDict = new Dictionary<int,int>();
    foreach (var num in nums)
    {
        if(countDict.ContainsKey(num)) continue;
        countDict.Add(num, nums.Count(x => x == num));
    }

    var i = 0;
    foreach (var dict in countDict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value).TakeWhile(dict => i < k))
    {
        result.Add(dict.Key);
        i++;
    }
    return result.ToArray();
    }
}