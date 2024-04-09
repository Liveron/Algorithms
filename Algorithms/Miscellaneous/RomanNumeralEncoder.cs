using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Miscellaneous
{
    public static class RomanNumeralEncoder
    {
        static readonly Dictionary<int, string> _decimalRoman = new()
        {
            { 1, "I" },
            { 5, "V" },
            { 10, "X" },
            { 50, "L" },
            { 100, "C" },
            { 500, "D" },
            { 1000, "M" },
        };

        //public static string Encode(int decim)
        //{
        //    string decimStr = decim.ToString();
        //    return _decimalRoman[decimStr];
        //}
    }
}
