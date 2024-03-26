namespace _06._Ascending_and_descending_row
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int previousNumber = int.MinValue;
            int currentNumber = 0;
            bool isAscending = true;
            bool isDescending = true;
            bool firstNumberEntered = false;

            while (true)
            {
                currentNumber = int.Parse(Console.ReadLine());

                if (!firstNumberEntered)
                {
                    previousNumber = currentNumber;
                    firstNumberEntered = true;
                    continue;
                }

                if (currentNumber <= 0)
                {
                    break;
                }

                if (currentNumber > previousNumber)
                {
                    isDescending = false;
                }
                else if (currentNumber < previousNumber)
                {
                    isAscending = false;
                }

                previousNumber = currentNumber;
            }

            if (isAscending && !isDescending)
            {
                Console.WriteLine("The entered numbers form an ascending row.");
            }
            else if (isDescending && !isAscending)
            {
                Console.WriteLine("The entered numbers form a descending row.");
            }
            else
            {
                Console.WriteLine("The numbers entered form neither ascending nor descending sequence.");
            }
        }
    }
}