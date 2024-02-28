namespace _02._Find_digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());
            int firstDigit, lastDigit;
            for(int i = 10; i < 99; i++)
            {
                lastDigit = i % 10;
                firstDigit = i / 10;
                if(firstDigit == digit || lastDigit == digit)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}