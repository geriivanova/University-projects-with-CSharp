namespace _13.__Guess_the_random_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1,50);

            for (int i = 0; i < 5; i++)
            {
                int numbering = i + 1;
                Console.Write($"{numbering} try: ");
                int number = int.Parse(Console.ReadLine());
                while (number < 1 || number > 50)
                {
                    Console.WriteLine("Enter new number between 1 and 50!");
                    number = int.Parse(Console.ReadLine());
                }
                
                if(number == randomNumber)
                {
                    Console.WriteLine($"Congratulations, you guess the random number! The random number is {randomNumber}");
                    return;
                }
                else
                {
                    if(numbering < 5)
                    {
                        Console.WriteLine("Sorry, you did not guess the number! Try again.");
                    }
                }
            }

            Console.WriteLine($"Game over! The random number is: {randomNumber}");
        }
    }
}