namespace Algorithms.Tests;

public class BraceBalanceTest
{
    [Theory]
    [InlineData("()[][{}]")]
    [InlineData("(Hello{World}!)")]
    public void Invoke_DifferentValues_ReturnTrue(string value)
    {
        bool result = BraceBalance.Invoke(value);

        Assert.True(result);
    }

    [Theory]
    [InlineData("[}")]
    [InlineData("(]")]
    public void Invoke_DifferentValues_ReturnFalse(string value)
    {
        bool result = BraceBalance.Invoke(value);

        Assert.False(result);
    }

    [Fact]
    public void Invoke_NoBraces_ReturnTrue()
    {
        string strubString = string.Empty;

        bool result = BraceBalance.Invoke(strubString);

        Assert.True(result);
    }
}