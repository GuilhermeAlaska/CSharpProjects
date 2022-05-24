using System;
using System.Linq;

namespace CountSwaps
{
    public static class Swap
    {
        public static int GetMinimumSwaps(int[] array)
        {
            int swapsCount = 0;

            int minValue = array.Min();

            int minValueIndex = GetValueIndex(array, minValue);

            swapsCount += MoveItensAndReturnSwaps(array, minValue, minValueIndex, 0);

            int maxValue = array.Max();

            int maxValueIndex = GetValueIndex(array, maxValue);

            swapsCount += MoveItensAndReturnSwaps(array, maxValue, maxValueIndex, array.Length - 1);

            return swapsCount;
        }

        private static int MoveItensAndReturnSwaps(int[] array, int itemValue, int itemIndex, int expectedItemFinalIndex)
        {
            int swaps = 0;

            bool isInPlace = false;

            if (itemIndex < expectedItemFinalIndex)
            {
                do
                {
                    int i = itemIndex + 1;

                    if (array[expectedItemFinalIndex] == itemValue)
                        isInPlace = true;

                    if (i == array.Length)
                        break;


                    var temp = array[i];

                    array[i] = array[itemIndex];

                    array[itemIndex] = temp;

                    itemIndex = i;

                    swaps++;
                }
                while (!isInPlace);
            }
            else
            {
                do
                {
                    int i = itemIndex - 1;

                    if (array[0] == itemValue)
                        isInPlace = true;

                    if (i < 0)
                        break;


                    var temp = array[i];

                    array[i] = array[itemIndex];

                    array[itemIndex] = temp;

                    itemIndex = i;

                    swaps++;
                }
                while (!isInPlace);
            }

            return swaps;
        }

        private static int GetValueIndex(int[] array, int numberToSearch)
        {
            var temp = Array.IndexOf(array, numberToSearch);
            return temp;
        }
    }
}