namespace Algorithms.Miscellaneous
{
    public static class ObservedPIN
    {
        public static List<string> GetPINs(string observed)
        {
            var possibleValues = new Dictionary<int, List<int>>();
            
            for (int digit = 0; digit <= 9; digit++)
            {
                if (digit == 0)
                {
                    possibleValues.Add(digit, [8, 0]);
                    continue;
                }

                int row = Convert.ToInt32(Math.Round(digit / 3.0, MidpointRounding.ToPositiveInfinity));

                possibleValues.Add(digit, [digit]);

                int rightBound = row * 3;
                int leftBound = rightBound - 2;

                if (digit + 1 <= rightBound)
                {
                    possibleValues[digit].Add(digit + 1);
                }
                if (digit - 1 >= leftBound) 
                {
                    possibleValues[digit].Add(digit - 1);
                }

                int downBound = 1;
                int upBound = 9;

                if (digit - 3 >= downBound)
                {
                    possibleValues[digit].Add(digit - 3);
                }
                if (digit + 3 <= upBound)
                {
                    possibleValues[digit].Add(digit + 3);
                }

                if (digit == 8)
                { 
                    possibleValues[digit].Add(0);
                }
            }

            return observed.Aggregate(new List<string> { string.Empty },
                (accumulator, number) => accumulator.SelectMany(
                    x => possibleValues[Convert.ToInt32(char.GetNumericValue(number))],
                (y, z) => y + z).ToList());
        }
    }
}
