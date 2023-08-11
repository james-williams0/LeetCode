using TwoSums.HashMaps;

namespace Tests.P1.TwoSum;

public class TwoSumHashMapSolutionTests
{
    private readonly Solution _solution = new();

    [Fact]
    public void Given_2_7_11_15_AndTarget_9_Expect_0_1()
    {
        var nums = new[] { 2, 7, 11, 15 };
        const int target = 9;
        var expected = new[] { 0, 1 };

        var actual = _solution.TwoSum(nums, target);
        
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void Given_3_2_4_AndTarget_6_Expect_1_2()
    {
        var nums = new[] { 3, 2, 4 };
        const int target = 6;
        var expected = new[] { 1, 2 };

        var actual = _solution.TwoSum(nums, target);
        
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void Given_3_3_AndTarget_6_Expect_0_1()
    {
        var nums = new[] { 3, 3 };
        const int target = 6;
        var expected = new[] { 0, 1 };

        var actual = _solution.TwoSum(nums, target);
        
        Assert.Equal(expected, actual);
    }
}