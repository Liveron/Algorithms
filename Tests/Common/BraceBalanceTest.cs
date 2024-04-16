using Algorithms.Common.String;

namespace Algorithms.Tests.Common;

public class BraceBalanceTest
{
    [Theory]
    [InlineData("()[][{}]")]
    [InlineData("(Hello{World}!)")]
    public void Invoke_SymmetricalValues_ReturnsTrue(string value)
    {
        bool result = BraceBalance.Invoke(value);

        Assert.True(result);
    }

    [Theory]
    [InlineData("[}")]
    [InlineData("(]")]
    public void Invoke_AsymmetricalValues_ReturnsFalse(string value)
    {
        bool result = BraceBalance.Invoke(value);

        Assert.False(result);
    }

    [Fact]
    public void Invoke_EmptyString_ReturnsTrue()
    {
        string strubString = string.Empty;

        bool result = BraceBalance.Invoke(strubString);

        Assert.True(result);
    }
}