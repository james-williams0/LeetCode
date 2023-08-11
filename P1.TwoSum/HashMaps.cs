// ReSharper disable once CheckNamespace
namespace TwoSums.HashMaps;

// Beats 95.23% on runtime @ 133ms
// Low memory efficiency, only beats 5.34% @ 48.4MB
// As of 2023-08-11 13:23
public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, List<int>>();

        foreach (var kvp in nums.Select((num, index) => (num, index)))
        {
            var num = kvp.num;
            var index = kvp.index;
            var exists = !dict.TryAdd(num, new List<int>{index});
            if (exists) dict[num].Add(index);
        }
        
        for (var i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];
            
            if (dict.TryGetValue(diff, out var indices))
            {
                if (indices.Count == 1)
                {
                    var j = indices.Single();
                    if (i != j)
                    {
                        return new[] { i, j };
                    }
                }
                else
                {
                    if (diff == nums[i])
                    {
                        dict.TryGetValue(diff, out indices);
                        return new[] { i, indices![1] };
                    }
                }
            }
        }
        return null!;
    }
}
