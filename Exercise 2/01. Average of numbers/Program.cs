namespace _01._Average_of_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0;
            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);
            int.TryParse(Console.ReadLine(), out c);

            decimal average = 0;
            decimal sum = 0;

            sum = a + b + c;
            average = sum / 3;
            Console.WriteLine($"{average:F2}");
        }
    }
}