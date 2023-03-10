namespace HW1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Task 1. Create app for counting numbers sum from 1 to 100.
            int firstNumber = 1;
            int lastNumber = 100;
            int sum = 0;
            for (int i = firstNumber; i <= lastNumber; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Sum of numbers from {firstNumber} to {lastNumber} is {sum}.");
        }
    }
}