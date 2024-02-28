namespace Max_and_Average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;
            int number = int.Parse(Console.ReadLine());
            double average = 0;
            int maxNumber = int.MinValue;
            while (number != 0)
            {
                count++;
                sum += number;
                if(number > maxNumber)
                {
                    maxNumber = number;
                }
                number = int.Parse(Console.ReadLine());
            }

            average = (double)sum / count;
            Console.WriteLine(average);
            Console.WriteLine(maxNumber);
        }
    }
}