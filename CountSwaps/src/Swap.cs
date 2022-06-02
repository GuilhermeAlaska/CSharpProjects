using System;
using System.Linq;

namespace CountSwaps
{
    public static class Swap
    {
        public static int GetMinimumSwaps(int[] array)
        {
            int minValue = array.Min();

            int minValueIndex = Array.IndexOf(array, minValue);

            int minValueSwaps = 0 + minValueIndex;


            int maxValue = array.Max();

            int maxValueIndex = Array.IndexOf(array, maxValue);


            if (minValueIndex > maxValueIndex)
                maxValueIndex++;


            int maxValueSwaps = (maxValueIndex - (array.Length - 1)) * -1;


            int minimumSwaps = minValueSwaps + maxValueSwaps;

            return minimumSwaps;
        }
    }
}