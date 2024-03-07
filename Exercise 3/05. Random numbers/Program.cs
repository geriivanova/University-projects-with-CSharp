namespace _05._Random_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            Random random = new Random();

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-3000,3000);
                Console.WriteLine("Random number: ");
                Console.WriteLine(numbers[i]);
            }
            
            for(int i = 0; i <= numbers.Length; i+=2)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}