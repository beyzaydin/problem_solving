public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var result = new int[nums.Length];
        int num = 1, i;

        for (i = 0; i < nums.Length; i++)
        {
            result[i] = num;
            num *= nums[i];
        }

        for (i = nums.Length - 1,num = 1; i >= 0; i--)
        {
            result[i] *= num;
            num *= nums[i];
        }

        return result;
    }
}