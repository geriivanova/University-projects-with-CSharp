namespace _08._Ignore_same_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int countOfNumbers = 1;
            int previousNumber = firstNumber;
            int currentNumber;
            int minNumber = firstNumber;
            decimal sumOfNumbers = 0;
            sumOfNumbers += firstNumber;


            for (int i = 2; i <= 10; i++)
            {
                currentNumber = int.Parse(Console.ReadLine());
                
                if(currentNumber != previousNumber)
                {
                    countOfNumbers++;
                    sumOfNumbers += currentNumber;
                }
                if(currentNumber < minNumber)
                {
                    minNumber = currentNumber;
                }
                previousNumber = currentNumber;
            }
            decimal average = (sumOfNumbers / countOfNumbers);
            Console.WriteLine($"Average is: {average:F2}, minumum is {minNumber}");
        }
    }
}