namespace _02.__Sum_of_absolute_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];
            int sum = 0;

            for(int i = 0; i < size; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                if (numbers[i] < 0)
                {
                    sum += Math.Abs(numbers[i]);
                }
                else
                {
                    sum += numbers[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}