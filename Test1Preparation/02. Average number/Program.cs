namespace _02._Average_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumOfNumbers = 0;
            int countOfNumbers = 0;
            double average;
            int maxNumber = int.MinValue;
            int number = int.Parse(Console.ReadLine());
            while (number != 0)
            {
                sumOfNumbers += number;
                countOfNumbers++;
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
                number = int.Parse(Console.ReadLine());
            }
            average = (double)(sumOfNumbers / countOfNumbers);
            Console.WriteLine($"Average: {average:F2}, Max number: {maxNumber}");
        }
    }
}