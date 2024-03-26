namespace _11._Count_of_equal_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int countNumber = 1;
            int newNumber;
            do
            {
                newNumber = int.Parse(Console.ReadLine());
                if(newNumber == number)
                {
                    countNumber++;
                }
            }
            while (newNumber == number);

            Console.WriteLine($"{number} - {countNumber} times.");
        }
    }
}