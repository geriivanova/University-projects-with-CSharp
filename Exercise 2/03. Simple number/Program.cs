namespace _03._Simple_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if(number == 0 || number == 1)
            {
                Console.WriteLine($"{number} is not a prime number");
            }
            else if(number % 2 == 0 || 
                    number % 3 == 0 || 
                    number % 4 == 0 || 
                    number % 5 == 0 || 
                    number % 6 == 0 ||
                    number % 7 == 0 ||
                    number % 8 == 0 ||
                    number % 9 == 0)
                 {
                    Console.WriteLine($"{number} is not a prime number");
                 }
            
            else
            {
                Console.WriteLine($"{number} is a prime number");
            }
        }
    }
}