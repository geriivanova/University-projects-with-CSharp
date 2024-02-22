namespace _06.ReplaceDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                int digit = n % 10;
                Console.Write(digit + " ");
                for (int i = 0; i < digit; i++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
                n = n / 10;
            }
        }
    }
}