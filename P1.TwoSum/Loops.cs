// ReSharper disable once CheckNamespace
namespace TwoSums.Loops;

// Beats 56.49% on runtime @ 163ms
// Beats 81.61% on memory use @ 44.2MB
// As of 2023-08-11 1:08
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (var i = 0; i < nums.Length - 1; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new[]{i, j};
                }
            }
        }
        return null!;
    }
}
