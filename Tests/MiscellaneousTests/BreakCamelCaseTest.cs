namespace Tests.MiscellaneousTests
{
    public class BreakCamelCaseTest
    {
        [Theory]
        [InlineData("camelCase", "camel Case")]
        [InlineData("camelCaseSecond", "camel Case Second")]
        public void Invoke_Should_BeEqual(string camel, string spaceDivided)
        {
            string result = BreakCamelCase.Invoke(camel);

            Assert.Equal(spaceDivided, result);
        }
    }
}
