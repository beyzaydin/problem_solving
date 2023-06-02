public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];
        int num, i;

        for (num = 1, i = 0; i < nums.Length; i++)
        {
            result[i] = num;
            num *= nums[i];
        }

        for (num = 1, i = nums.Length - 1; i >= 0; i--)
        {
            result[i] *= num;
            num *= nums[i];
        }

        return result;
    }
}