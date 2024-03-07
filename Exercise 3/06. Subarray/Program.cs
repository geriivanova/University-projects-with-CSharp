namespace _06._Subarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = new int[10];
            int[] secondArray = new int[3];

            Console.WriteLine("Enter first array: ");
            for(int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter second array: ");
            for (int i = 0;i < secondArray.Length;i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            if(secondArray.All(x => firstArray.Contains(x)))
            {
                Console.WriteLine("Second array is subarray");
            }
            else
            {
                Console.WriteLine("Second array is not subarray");
            }
        }
    }
}