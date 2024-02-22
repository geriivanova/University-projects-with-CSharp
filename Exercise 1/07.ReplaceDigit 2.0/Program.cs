namespace _07.ReplaceDigit_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number: ");
            string number = Console.ReadLine();
            for(int i = 0; i < number.Length; i++) 
            {
                int digit = int.Parse(number[i].ToString());
                Console.Write(digit + " ");
                for(int j = 0; j < digit; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}