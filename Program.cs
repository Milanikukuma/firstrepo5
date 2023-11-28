namespace ClassExercise6
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            int[] allNumbers = { -1, 2, 4, 6, 9 };

            int[] result = CountTheNegativeAndPositiveNumbers.CountPosandNegNumbers(allNumbers);
            string returnString = "Total Positive: " + result[1] + " Total Negative: " + result[0];
            Console.WriteLine(returnString);



        }
    }
}
