namespace Algorithms.CodeWars
{
    public static class RGBToHexConverter
    {
        public static string Convert(int r, int g, int b)
        {
            return DecimalToHexStr(r) + DecimalToHexStr(g) + DecimalToHexStr(b);
        }

        private static string DecimalToHexStr(int dec)
        {
            int roundedDec = dec switch
            {
                < 0 => 0,
                > 255 => 255,
                _ => dec,
            };

            return roundedDec.ToString("X2");
        }
    }
}
