namespace _05._Number_of_matches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b = int.Parse(Console.ReadLine());
            int count = 0;  

            for(int i = 0; i < 10; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if(number == b)
                {
                    count++;
                }
            }

            if(count != 0)
            {
                Console.WriteLine($"Yes, {b} exists. The number occurs {count} times.");
            }
            else
            {
                Console.WriteLine($"{b} does not exist.");
            }
        }
    }
}