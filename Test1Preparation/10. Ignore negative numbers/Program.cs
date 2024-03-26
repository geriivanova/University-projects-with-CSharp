namespace _10._Ignore_negative_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 5;
            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;

            while (count > 0)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > 0)
                {
                    count--;
                    if (number < minNumber)
                    {
                        minNumber = number;
                    }
                    if (number > maxNumber)
                    {
                        maxNumber = number;
                    }
                    continue;
                }
            }
            Console.WriteLine($"Max number is: {maxNumber}, Min number is: {minNumber}");
        }
    }
}