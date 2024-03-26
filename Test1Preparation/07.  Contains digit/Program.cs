namespace _07.__Contains_digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firmName = string.Empty;
            string neededFirm = string.Empty;

            for (int i = 1; i <= 5; i++)
            {
                firmName = Console.ReadLine();

                if(firmName.Any(char.IsDigit))
                {
                    neededFirm += firmName + " ";
                }
            }
            Console.WriteLine(string.Join(" ", neededFirm));
        }
    }
}