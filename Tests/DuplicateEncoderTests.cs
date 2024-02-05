namespace Tests
{
    public class DuplicateEncoderTests
    {
        [Theory]
        [InlineData("hello")]
        public void Invoke_LowerCase(string word)
        {
            string result = DuplicateEncoder.Invoke(word);

            Assert.Equal("(())(", result);
        }

        [Theory]
        [InlineData("HeLlo")]
        public void Invoke_UpperCase(string word)
        {
            string result = DuplicateEncoder.Invoke(word);

            Assert.Equal("(())(", result);
        }
    }
}
