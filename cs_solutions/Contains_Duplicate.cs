public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        return !((nums.ToList().Count) == (nums.ToList().Select(x => x).Distinct().Count()));
    }
}