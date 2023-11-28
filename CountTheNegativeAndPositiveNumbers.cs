using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise6
{
    internal class CountTheNegativeAndPositiveNumbers
    {
        public static int[] CountPosandNegNumbers(int[] numbers)
        {
            int negativeNumbers = 0;
            int positiveNumbers = 0;


            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    negativeNumbers++;
                }


                


                if (numbers[i] > 0)
                {
                    positiveNumbers++;
                }


            }
            int[] result = new int[2];
            result[0] = negativeNumbers;
            result[1] = positiveNumbers;

            return result;

        }

    }
}
