using System;

namespace ReplaySet.Common.Util
{
    public static class Helpers
    {
        /// <summary>
        /// Generates an <see cref="int"/>, with the minimum of 0, inclusive, and specified maximum,
        /// exclusive.
        /// </summary>
        public static int GenerateRandomInteger(int maximum)
        {
            return new Random().Next(maximum);
        }
    }
}