namespace _09._Even_or__odd_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfOdd = 0;
            int countOfEven = 0;

            for(int i = 0; i < 7; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if(number % 2 == 0)
                {
                    countOfEven++;
                }
                else if(number % 2 != 0)
                {
                    countOfOdd++;
                }
            }
            if(countOfOdd == 7)
            {
                Console.WriteLine("The numbers are only odd.");
            }
            else if(countOfEven == 7)
            {
                Console.WriteLine("The numbers are only even.");
            }
            else
            {
                Console.WriteLine("The numbers are both even and odd.");
            }
        }
    }
}