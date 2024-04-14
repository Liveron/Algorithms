namespace Tests.MiscellaneousTests
{
    public class RomanNumeralDecoderTest
    {
        [Theory]
        [InlineData("I", 1)]
        [InlineData("MDCLXVI", 1666)]
        [InlineData("MCMLIV", 1954)]
        public void Decode_ReturnsDecimal(string roman, int decim)
        {
            int result = RomanNumeralDecoder.Decode(roman);

            Assert.Equal(decim, result);
        }
    }
}
