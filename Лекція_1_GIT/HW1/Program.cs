namespace HW1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int firstNumber = 1;
            int lastNumber = 100;
            int sum =0;
            for (int i = firstNumber; i <= lastNumber; i++)
            {
                sum+=i;
            }
            Console.WriteLine($"Sum of numbers from {firstNumber} to {lastNumber} is {sum}.");
        }
    }
}