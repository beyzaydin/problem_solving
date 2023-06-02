public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var result = new List<int>();
        var numList = nums.ToList();

        var i = 0;
        foreach (var num in numList)
        {
            var temp = target - num;
            if (numList.Contains(temp)&&numList.FindIndex(x => x==temp)!=i)
            {
                result.Add(i);
                result.Add(numList.FindIndex(x => x==temp));
            }
            i++;
        }

        return result.Distinct().ToArray();
    }
}