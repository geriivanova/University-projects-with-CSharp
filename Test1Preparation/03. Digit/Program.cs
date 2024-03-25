namespace _03._Digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int firstDigit;
            int lastDigit;
            for(int i = 10; i <= 99; i++)
            {
                lastDigit = i % 10;
                firstDigit = i / 10;
                if(firstDigit == number || lastDigit == number)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}