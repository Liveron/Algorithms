namespace Algorithms.Tests.CodeWars
{
    public class BreakCamelCaseTest
    {
        [Theory]
        [InlineData("camelCase", "camel Case")]
        [InlineData("camelCaseSecond", "camel Case Second")]
        public void Invoke_CamelCaseString_DividedString(string camel, string spaceDivided)
        {
            string result = BreakCamelCase.Invoke(camel);

            Assert.Equal(spaceDivided, result);
        }

        [Fact]
        public void Invoke_EmptyString_EmptyString()
        {
            string result = BreakCamelCase.Invoke(string.Empty);

            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void Invoke_Null_ThrowsNullReferenceException()
        {
            Assert.Throws<NullReferenceException>(() => BreakCamelCase.Invoke(null));
        }
    }
}
