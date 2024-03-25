namespace _04._Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string symbols = string.Empty;

            for(int i = 0; i < n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                symbols += symbol;
            }
            Console.WriteLine(string.Join(" ", symbols.Reverse()));
        }
    }
}