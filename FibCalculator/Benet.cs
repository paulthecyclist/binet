using System;

namespace FibCalculator
{
    public static class Benet
    {
        private static readonly double Sqrt5 = Math.Sqrt(5);
        private static readonly double GoldenRatio = 1.618034;

        public static int NthNumber(int n)
        {
            var goldenToPower = Math.Pow(GoldenRatio, n);
            var negativeGoldenPower = Math.Pow((1 - GoldenRatio), n);

            var result = (goldenToPower - negativeGoldenPower) / Sqrt5;

            return Convert.ToInt32(Math.Round(result));
        }
    }
}
